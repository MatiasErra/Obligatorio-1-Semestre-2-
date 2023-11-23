using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class Cliente
    {
        private short _id;
        private string _nombre;
        private string _apellido;
        private int _telefono;
        private int _cedula;
  
        public short Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }

        public override string ToString()
        {
            return this.Id + " " + this.Nombre + " " + this.Apellido + " " + this.Telefono;
        }

        public Cliente(short pId, string pNombre, string pApellido, int pTelefono, int pCedula)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Cedula = pCedula;
        }
     

    }
}
