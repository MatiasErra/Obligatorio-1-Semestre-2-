using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class Propiedad
    {
        private short _id;
        private string _dirrecion;
        private string _ciudad;
        private Boolean _garaje;
        private string _barrio;
        private short _m2;
        private ClienteVenta _clienteVenta;

        public short Id { get => _id; set => _id = value; }
        public string Dirrecion { get => _dirrecion; set => _dirrecion = value; }
        public string Barrio { get => _barrio; set => _barrio = value; }
        public Boolean Garaje { get => _garaje; set => _garaje = value; }
        public short M2 { get => _m2; set => _m2 = value; }
        internal ClienteVenta ClienteVenta { get => _clienteVenta; set => _clienteVenta = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }

        public override string ToString()
        {
            return this.Id + " " + this.Dirrecion + " " +this.Ciudad + " " + this.Barrio + " " + this.M2 + " "  +this.ClienteVenta;
        }

        public Propiedad(short pId, Boolean pGaraje, string pDirrecion, string pCiudad, string pBarrio, short pM2, ClienteVenta pClienteVenta)
        {
            this.Id = pId;
            this.Dirrecion = pDirrecion;
            this.Garaje = pGaraje;
            this.Ciudad = pCiudad;
            this.Barrio = pBarrio;
            this.M2 = pM2;
            this.ClienteVenta = pClienteVenta;
        }

    }
}
