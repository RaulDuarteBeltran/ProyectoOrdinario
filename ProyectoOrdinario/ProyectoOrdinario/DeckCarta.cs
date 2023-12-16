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
    public DeckCarta(FigurasCartasEnum figura, ValoresCartasEnum valor) : base(figura, valor)
    {
        deck = new List<Carta>();
        carta = new Carta(figura, valor);
    }

    //public Carta[] obtenerDeck {get{ return deck;}}

    public void CrearDeck()
    {
        foreach (FigurasCartasEnum figura in Enum.GetValues(typeof(FigurasCartasEnum)))
        {
            foreach (ValoresCartasEnum valor in Enum.GetValues(typeof(ValoresCartasEnum)))
            {
                deck.Add(new Carta(figura, valor));
            }
        }

        BarajarCartas();
    }

    public void BarajarCartas()
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

    ICarta VerCarta(int indiceCarta){
        return deck[indiceCarta];
    }

    ICarta SacarCarta(int indiceCarta){
        ICarta carta = deck[indiceCarta];
        deck.RemoveAt(indiceCarta);
        return carta;
    }

    void MeterCarta(ICarta carta){
        deck.Add((Carta)carta);
    }

    void MeterCarta(List<ICarta> cartas){
        deck.AddRange((IEnumerable<Carta>)cartas);
    }
}
