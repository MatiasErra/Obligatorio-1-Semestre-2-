using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class Venta
    {
        private short _id;
        private DateTime _fecha;
        private Casa _casa;
        private Apartamento _apartamento;
        private short _precio;
        private ClienteComp _clienteComp;


        public short Id { get => _id; set => _id = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        internal Casa Casa { get => _casa; set => _casa = value; }
        public short Precio { get => _precio; set => _precio = value; }
        internal ClienteComp ClienteComp { get => _clienteComp; set => _clienteComp = value; }
        internal Apartamento Apartamento { get => _apartamento; set => _apartamento = value; }

        public override string ToString()
        {
            return this.Id + " " + this.Fecha + " " + this. Precio +  " " + this.ClienteComp.Id;
        }

        public Venta(short pId, DateTime pFecha, short pPrecio, Casa pCasa, Apartamento pApartamento, ClienteComp pClienteComp)
        {
            this.Id = pId;
            this.Fecha = pFecha;
            this.Precio = pPrecio;
            this.Casa = pCasa;
            this.Apartamento = pApartamento;
            this.ClienteComp = pClienteComp;
        }

       

    }
}
