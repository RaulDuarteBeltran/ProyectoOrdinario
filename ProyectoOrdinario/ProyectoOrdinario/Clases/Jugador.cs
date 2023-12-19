using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdinario.Clases
{
    public class Jugador : IJugador
    {
        private List<ICarta> mano;

        public IDealer Dealer { get; set; }

        public Jugador()
        {
            mano = new List<ICarta>();
        }

        public void RealizarJugada()
        {
            Console.WriteLine("Player´s turn: ");

            while (CalcularPuntuacion() <= 21)
            {
                Console.WriteLine($"Current Hand: {string.Join(", ", MostrarCartas().Select(carta => $"{carta.Valor} de {carta.Figura}"))}");
                Console.WriteLine($"Current Score: {CalcularPuntuacion()}");

                Console.Write("Do you want to Hit (H) or Stand (S): ");
                var decision = Console.ReadLine();

                if (decision.ToLower() == "h")
                {
                    // El jugador decide pedir una nueva carta
                    ObtenerCartas(new List<ICarta> { Dealer.RepartirCartas(1)[0] });
                    Console.WriteLine($"New Card: {MostrarCarta(mano.Count - 1).Valor} de {MostrarCarta(mano.Count - 1).Figura}");
                }
                else if (decision.ToLower() == "s")
                {
                    // El jugador decide plantarse
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'H' to Hit or 'S' to Stand.");
                }
            }

            Console.WriteLine($"Final Hand: {string.Join(", ", MostrarCartas().Select(carta => $"{carta.Valor} de {carta.Figura}"))}");
            Console.WriteLine($"Final Score: {CalcularPuntuacion()}");

            // Implement player's move logic
            Console.WriteLine("Player makes a move.");
        }

        public void ObtenerCartas(List<ICarta> cartas)
        {
            mano.AddRange(cartas);
        }

        public ICarta DevolverCarta(int indiceCarta)
        {
            var carta = mano[indiceCarta];
            mano.RemoveAt(indiceCarta);
            return carta;
        }

        public List<ICarta> DevolverTodasLasCartas()
        {
            var todasLasCartas = new List<ICarta>(mano);
            mano.Clear();
            return todasLasCartas;
        }

        public List<ICarta> MostrarCartas()
        {
            return new List<ICarta>(mano);
        }

        public ICarta MostrarCarta(int indiceCarta)
        {
            return mano[indiceCarta];
        }

        private int CalcularPuntuacion()
        {
            // Calcula la puntuación de la mano del jugador en el Blackjack
            int puntuacion = 0;
            int ases = 0;

            foreach (var carta in mano)
            {
                if (carta.Valor == ValoresCartasEnum.As)
                {
                    ases++;
                    puntuacion += 11; // El valor predeterminado es 11, se ajustará si es necesario
                }
                else
                {
                    puntuacion += (int)carta.Valor;
                }
            }

            // Ajusta el valor de los ases si la puntuación supera 21
            while (puntuacion > 21 && ases > 0)
            {
                puntuacion -= 10; // Cambia el valor del as de 11 a 1
                ases--;
            }

            return puntuacion;
        }
    }
}
