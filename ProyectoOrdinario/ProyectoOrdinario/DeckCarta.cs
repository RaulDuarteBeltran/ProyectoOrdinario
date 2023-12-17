using ProyectoOrdinario;
using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;
public class DeckCarta : Carta
{
    ICarta carta;
    const int NUMERO_CARTAS = 52;
    private List<Carta> deck;
    int indiceCarta;
    public DeckCarta(FigurasCartasEnum figura, ValoresCartasEnum valor) : base(figura, valor) //constructor
    {
        deck = new List<Carta>();
        carta = new Carta(figura, valor);
    }

    public List<Carta> obtenerDeck {get{ return deck;}}

    public void CrearDeck() //Con esto se crean las 52 cartas del poker
    {
        foreach (FigurasCartasEnum figura in Enum.GetValues(typeof(FigurasCartasEnum)))
        {
            foreach (ValoresCartasEnum valor in Enum.GetValues(typeof(ValoresCartasEnum)))
            {
                deck.Add(new Carta(figura, valor));
            }
        }

        BarajearCartas();
    }

    public void BarajearCartas() //Con este método se mezcla el orden de las cartas
    {
        Random random = new Random();
        Carta cartaTemporal;
        int indiceAleatorio;

        for (int i = 0; i < NUMERO_CARTAS; i++)
        {
            indiceAleatorio = random.Next(0, 52);
            cartaTemporal = deck[i];
            deck[i] = deck[indiceAleatorio];
            deck[indiceAleatorio] = cartaTemporal;
        }
    
    }

    ICarta VerCarta(int indiceCarta){ //Con este método se puede ver la carta que se encuentra en el indice que se le pase
        return deck[indiceCarta];
    }

    ICarta SacarCarta(int indiceCarta){ //Con este método se puede sacar la carta que se encuentra en el indice que se le pase
        ICarta carta = deck[indiceCarta];
        deck.RemoveAt(indiceCarta);
        return carta;
    }


    void MeterCarta(List<ICarta> cartas){ //Con este método se puede meter una carta al deck
        deck.AddRange((IEnumerable<Carta>)cartas);
    }
}
