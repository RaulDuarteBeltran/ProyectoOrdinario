using ProyectoOrdinario;
using ProyectoOrdinario.Enumeradores;
using System;
public class DeckCarta : Carta
{
    const int NUMERO_CARTAS = 52;
    private Carta[] deck;
    
    public DeckCarta(FigurasCartasEnum figura, ValoresCartasEnum valor) : base(figura, valor)
    {
        deck = new Carta[NUMERO_CARTAS];
    }

    public Carta[] obtenerDeck {get{ return deck;}}

    public void CrearDeck()
    {
        int i = 0;
        foreach (FigurasCartasEnum figura in Enum.GetValues(typeof(FigurasCartasEnum)))
        {
            foreach (ValoresCartasEnum valor in Enum.GetValues(typeof(ValoresCartasEnum)))
            {
                deck[i] = new Carta(figura, valor);
                i++;
            }
        }

        BarajarCartas();
    }

    public void BarajarCartas()
    {
        Random random = new Random();
        Carta carta;
        int numeroAleatorio;
        for (int i = 0; i < 200; i++)
        {
            numeroAleatorio = random.Next(0, deck.Length);
            carta = deck[i];
            deck[i] = deck[numeroAleatorio];
            deck[numeroAleatorio] = carta;
        }
    }
}
