namespace ProyectoOrdinario;
using System;
using ProyectoOrdinario.Enumeradores;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Juego de Cartas de Poker");

        SeleccionarJuego();
    }

    static int SeleccionarNumeroJugadores()
    {
        System.Console.WriteLine("¿Cuántos jugadores van a jugar?");
        int numeroJugadores = int.Parse(Console.ReadLine());
        return numeroJugadores;
    }

    static void SeleccionarJuego()
    {
        System.Console.WriteLine("¿Qué juego desea jugar?");
        System.Console.WriteLine("1. Poker");
        System.Console.WriteLine("2. BlackJack");
        System.Console.WriteLine("3. Juego secreto");
        System.Console.WriteLine("4. Salir");

        int seleccionarJuego = int.Parse(Console.ReadLine());
        int numeroJugadores = SeleccionarNumeroJugadores();

        switch (seleccionarJuego)
        {
            case 1:
                System.Console.WriteLine("Juego de Poker");
                JuegoPoker(numeroJugadores);
                break;
            case 2:
                System.Console.WriteLine("Juego de BlackJack");
                JuegoBlackJack(numeroJugadores);
                break;
            case 3:
                System.Console.WriteLine("Juego secreto");
                JuegoSecreto(numeroJugadores);
                break;
            default:

                break;
        }
    }

    static void JuegoPoker(int numeroJugadores)
    {
        System.Console.WriteLine("Juego de Poker");
        ArmadoDeck();
        

    }

    static void JuegoBlackJack(int numeroJugadores)
    {
        System.Console.WriteLine("Juego de BlackJack");
        ArmadoDeck();
       
    }

    static void JuegoSecreto(int numeroJugadores)
    {
        System.Console.WriteLine("Juego secreto");
        ArmadoDeck();
    }    

    static void ArmadoDeck()
    {
       DeckCarta deckCarta = new DeckCarta(FigurasCartasEnum.Corazones, ValoresCartasEnum.As);
        deckCarta.CrearDeck();
        
    }
    


}




