using ProyectoOrdinario.Interfaces;
using ProyectoOrdinario.Enumeradores;
using System;


namespace ProyectoOrdinario
{
    public class Carta : ICarta
    {
        public Carta(FigurasCartasEnum figura, ValoresCartasEnum valor)
        {
            this.Figura = figura;
            this.Valor = valor;
        }

        public FigurasCartasEnum Figura { get; }
        public ValoresCartasEnum Valor { get; }
        
        //comentario prueba
    }
}
