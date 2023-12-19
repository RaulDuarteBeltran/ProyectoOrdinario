using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdinario.Clases
{
    internal class Dealer
    {
        private List<ICarta> mazo;

        public Dealer()
        {
            mazo = new List<ICarta>();
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
            // Add code to shuffle the deck
            Console.WriteLine("Deck is shuffled.");
        }

        private void InicializarMazo()
        {
            // Add code to initialize the deck with cards
            // For simplicity, let's assume a standard 52-card deck
            Console.WriteLine("Deck is initialized.");
        }
    }
}
