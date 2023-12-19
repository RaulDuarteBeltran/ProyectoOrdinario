using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdinario.Clases
{
    internal class Carta: ICarta
    {
        public FigurasCartasEnum Figura { get; private set; }
        public ValoresCartasEnum Valor { get; private set; }

        public Carta(FigurasCartasEnum figura, ValoresCartasEnum valor)
        {
            Figura = figura;
            Valor = valor;
        }
    }
}
