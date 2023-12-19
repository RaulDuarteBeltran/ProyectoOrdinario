using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;

namespace ProyectoOrdinario.Clases
{
    internal class Carta : ICarta
    {
        public FigurasCartasEnum Figura { get; set; }
        public ValoresCartasEnum Valor { get; set; }

        public Carta(FigurasCartasEnum figura, ValoresCartasEnum valor)
        {
            Figura = figura;
            Valor = valor;
        }
    }
}
