using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class Casa : Propiedad
    {
        private Boolean _patio;
        private Boolean _barbaco;

        public Boolean Patio { get => _patio; set => _patio = value; }
        public Boolean Barbaco { get => _barbaco; set => _barbaco = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public Casa(short pId, Boolean pGaraje, string pDirrecion, string pCiudad, string pBarrio, short pM2, ClienteVenta pClienteVenta, Boolean pPatio, Boolean pBarbaco)
            :  base(pId, pGaraje, pDirrecion, pCiudad, pBarrio, pM2, pClienteVenta)
        {
            this.Patio = pPatio;
            this.Barbaco = pBarbaco;
        }
    }
}
