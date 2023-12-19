using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdinario.Clases
{
    internal class DeckDeCartas : IDeckDeCartas
    {
        private List<ICarta> cartas;
        private static Random random = new Random();


        public DeckDeCartas()
        {
            cartas = new List<ICarta>();
            InicializarDeck();
        }

        public void BarajearDeck()
        {
            // Barajar el mazo usando el algoritmo de Fisher-Yates
            int n = cartas.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = cartas[k];
                cartas[k] = cartas[n];
                cartas[n] = value;
            }
            Console.WriteLine("Deck is shuffled.");
        }

        public ICarta VerCarta(int indiceCarta)
        {
            return cartas[indiceCarta];
        }

        public ICarta SacarCarta(int indiceCarta)
        {
            var carta = cartas[indiceCarta];
            cartas.RemoveAt(indiceCarta);
            return carta;
        }

        public void MeterCarta(ICarta carta)
        {
            cartas.Add(carta);
        }

        public void MeterCarta(List<ICarta> cartas)
        {
            this.cartas.AddRange(cartas);
        }

        private void InicializarDeck()
        {
            foreach (FigurasCartasEnum figura in Enum.GetValues(typeof(FigurasCartasEnum)))
            {
                foreach (ValoresCartasEnum valor in Enum.GetValues(typeof(ValoresCartasEnum)))
                {
                    cartas.Add(new Carta(figura, valor));
                }
            }
            Console.WriteLine("Deck is initialized.");
        }
    }
}
