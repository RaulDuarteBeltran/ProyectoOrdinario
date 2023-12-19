using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoOrdinario.Clases
{
    internal class Dealer : IDealer
    {
        private List<ICarta> mazo;
        private List<ICarta> mano;

        public Dealer()
        {
            mazo = new List<ICarta>();
            mano = new List<ICarta>();
            InicializarMazo();
        }

        public List<ICarta> RepartirCartas(int numeroDeCartas)
        {
            var cartasRepartidas = mazo.Take(numeroDeCartas).ToList();
            mazo.RemoveRange(0, numeroDeCartas);
            return cartasRepartidas;
        }

        public void RecogerCartas(List<ICarta> cartas)
        {
            mazo.AddRange(cartas);
        }

        public void BarajearDeck()
        {
            // Implementación de la lógica para barajear el mazo
            // Por ejemplo, puedes usar el algoritmo de Fisher-Yates
            Random random = new Random();
            int n = mazo.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                ICarta value = mazo[k];
                mazo[k] = mazo[n];
                mazo[n] = value;
            }
            Console.WriteLine("Deck is shuffled.");
        }

        public void RealizarJugada()
        {
            while (PuntuacionMano() < 17)
            {
                List<ICarta> cartasRepartidas = RepartirCartas(1);
                Console.WriteLine("El crupier toma una carta.");
                foreach (var carta in cartasRepartidas)
                {
                    mano.Add(carta);
                    Console.WriteLine($"   {carta.Valor} de {carta.Figura}");
                }
            }

            // Mostrar las cartas del crupier al final de la jugada
            Console.WriteLine("Cartas finales del crupier:");
            foreach (var carta in mano)
            {
                Console.WriteLine($"   {carta.Valor} de {carta.Figura}");
            }
        }

        private int PuntuacionMano()
        {
            int puntuacion = 0;
            int ases = 0;

            foreach (var carta in mano)
            {
                if (carta.Valor == ValoresCartasEnum.As)
                {
                    ases++;
                    puntuacion += 11; // Suponemos inicialmente que el As vale 11
                }
                else if ((int)carta.Valor >= 10)
                {
                    puntuacion += 10;
                }
                else
                {
                    puntuacion += (int)carta.Valor;
                }
            }

            while (puntuacion > 21 && ases > 0)
            {
                puntuacion -= 10;
                ases--;
            }

            return puntuacion;
        }

        private void InicializarMazo()
        {
            // Agregar lógica para inicializar el mazo con cartas
            // Por simplicidad, asumamos una baraja estándar de 52 cartas
            // Puedes adaptar esto según tus necesidades
            mazo.Clear(); // Limpiar el mazo antes de inicializar

            foreach (FigurasCartasEnum figura in Enum.GetValues(typeof(FigurasCartasEnum)))
            {
                foreach (ValoresCartasEnum valor in Enum.GetValues(typeof(ValoresCartasEnum)))
                {
                    mazo.Add(new Carta(figura, valor));
                }
            }

            BarajearDeck(); // Barajear el mazo después de inicializar
        }

        // Implementación de los métodos específicos de Dealer
        public void ObtenerCartas(List<ICarta> cartas)
        {
            mano.AddRange(cartas);
        }

        public List<ICarta> MostrarCartas()
        {
            return mano.ToList();
        }
    }
}
