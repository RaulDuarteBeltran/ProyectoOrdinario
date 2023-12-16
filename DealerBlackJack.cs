using ProyectoOrdinario;
using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;

public class DealerBlackJack : DeckCarta //Clase del dealer del juego BlackJack21
{
    public void BarajearDeck() //Función para barajear el deck
    {
        CrearDeck(); //Llamamos a que se cree el deck

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
        int cartasPorJugador = 2; //Este es el numero de cartas por defecto del juego

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

        public AnalizarMano() //El dealer revisa si tiene menos de 17 puntos para seguir jugando
        {

        }

        public RecogerCartas() //Aqui el dealer come una carta del mazo
        {

        }

        public CambiarCartaJugador() //Para intercambiar las cartas que el jugador quiere descartar y enviar a la pila de descartes
        {

        }

        public TerminarJugada() //El dealer al tener mas de 16 puntos ya deja de jugar y guarda su jugada
        {

        }
    }