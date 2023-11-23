using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class ClienteVenta:Cliente
    {
         
        public override string ToString()
        {
            return base.ToString();
        }

        public ClienteVenta(short pId, string pNombre, string pApellido, int pTelefono, int pCedula)
             : base(pId, pNombre, pApellido, pTelefono, pCedula)
        { }
    }
}

