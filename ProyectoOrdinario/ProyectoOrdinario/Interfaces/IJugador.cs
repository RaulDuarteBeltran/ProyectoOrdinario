using System;
using System.Collections.Generic;
using ProyectoOrdinario.Interfaces;

public class JugadorPoker : IJugador
{
    private List<ICarta> cartas;

    public JugadorPoker()
    {
        cartas = new List<ICarta>();
    }

    public void RealizarJugada()
    {
        // checa si el jugador tiene pár o mejor
        if (tieneParoMejor())
        {
            Pedir();
        }
        else
        {
            Retirarse();
        }
    }

    private bool tieneParoMejor()
    {
        // esto es como lo simple, ya para el juego se necesitaran cosas mas complejas
        for (int i = 0; i < cartas.Count; i++)
        {
            for (int j = i + 1; j < cartas.Count; j++)
            {
                if (cartas[i].Valor == cartas[j].Valor)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private void Pedir()
    {
        //aqui va la logica de pedir
        Console.WriteLine("El jugador pide");
    }

    private void Retirarse()
    {
        //aqui va la logica de pretirarse
        Console.WriteLine("El jugador se retira");
    }

    public void ObtenerCartas(List<ICarta> nuevasCartas)
    {
        cartas.AddRange(nuevasCartas);
    }

    public ICarta DevolverCarta(int indiceCarta)
    {
        ICarta carta = cartas[indiceCarta];
        cartas.RemoveAt(indiceCarta);
        return carta;
    }

    public List<ICarta> DevolverTodasLasCartas()
    {
        List<ICarta> todasLasCartas = new List<ICarta>(cartas);
        cartas.Clear();
        return todasLasCartas;
    }

    public List<ICarta> MostrarCartas()
    {
        return new List<ICarta>(cartas);
    }

    public ICarta MostrarCarta(int indiceCarta)
    {
        return cartas[indiceCarta];
    }
}

