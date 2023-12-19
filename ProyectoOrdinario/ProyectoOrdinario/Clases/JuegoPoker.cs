using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdinario.Clases
{
    internal class JuegoPoker: IJuego
    {
        private IDealer dealer;
        private List<IJugador> jugadores;

        public JuegoPoker(IDealer dealer)
        {
            this.dealer = dealer;
            jugadores = new List<IJugador>();
        }

        public IDealer Dealer => dealer;
        public bool JuegoTerminado { get; private set; }

        public void AgregarJugador(IJugador jugador)
        {
            jugadores.Add(jugador);
        }

        public void IniciarJuego()
        {
            Console.WriteLine("Poker game is starting.");
            // Add code to start the game
        }

        public void JugarRonda()
        {
            Console.WriteLine("Playing a round of Poker.");
            // Add code to play a round of Poker
            foreach (var jugador in jugadores)
            {
                jugador.RealizarJugada();
            }
        }

        public void MostrarGanador()
        {
            Console.WriteLine("Displaying the winner of the Poker game.");
            // Add code to determine and display the winner
        }
    }
}
