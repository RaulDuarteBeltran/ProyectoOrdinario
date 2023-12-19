using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdinario.Clases
{
    internal class DeckDeCartas: IDeckDeCartas
    {
        private List<ICarta> cartas;

        public DeckDeCartas()
        {
            cartas = new List<ICarta>();
            InicializarDeck();
        }

        public void BarajearDeck()
        {
            // Add code to shuffle the deck
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
            // Add code to initialize the deck with cards
            // For simplicity, let's assume a standard 52-card deck
            Console.WriteLine("Deck is initialized.");
        }
    }
}
