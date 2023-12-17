using ProyectoOrdinario;
using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;

public class DealerPoker	//Clase del dealer del juego Poker
{
    static void Main(string[] args)
    {

    }

    public void BarajearDeck() //Función para barajear el deck
    {

        Random random = new Random;
        int n = DeckCarta.Count;
        for (int i = 0; i < NUMERO_CARTAS; i++)
        {
            int k = random.Next(0, 52);
            ICarta carta = DeckCarta[k];
            DeckCarta[k] = DeckCarta[n];
            DeckCarta[n] = carta;
        }
    }

    public void RepartirCartas() //Función para repartir las cartas del deck a los jugadores (en este caso no juega el dealer)
    {
        int cartasPorJugador = 5; //Este es el numero de cartas por defecto del juego

        for (int i = 0; i < cartasPorJugador; i++)
        {
            foreach (Jugador jugador in jugadores)
            {
                if (DeckCarta.Count > 0)
                {
                    ICarta cartaRepartida = DeckCarta[DeckCarta.Count - 1];
                    DeckCarta.RemoveAt(DeckCarta.Count - 1);

                    // Agregar la carta al jugador
                    jugador.Add(cartaRepartida); // Esto asume que la clase Jugador tiene un método para agregar cartas a la mano del jugador
                }
                else
                {
                    Console.WriteLine("No hay suficientes cartas en el mazo para repartir.");
                    break; // Romper el bucle si no hay cartas suficientes en el mazo
                }
            }
        }
    }

    public void CambiarCartas() //Para intercambiar las cartas que el jugador quiere descartar y enviar a la pila de descartes
    {
        Mano.Add(Carta);
    }
}

