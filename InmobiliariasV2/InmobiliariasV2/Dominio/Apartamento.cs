using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class Apartamento : Propiedad
    {
        private short _num;

        public short Num { get => _num; set => _num = value; }

        public override string ToString()
        {
            return base.ToString()+ " " + this.Num;
        }

        public Apartamento(short pId, Boolean pGaraje, string pDirrecion, string pCiudad, string pBarrio, short pM2, ClienteVenta pClienteVenta, short pNum)
            : base(pId, pGaraje, pDirrecion, pCiudad, pBarrio, pM2, pClienteVenta)
        {
            this.Num = pNum;
        }
    }
}
