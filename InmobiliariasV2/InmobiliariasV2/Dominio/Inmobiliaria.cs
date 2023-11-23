using System;
using System.Collections.Generic;
using System.Text;

namespace InmobiliariasV2.Dominio
{
    class Inmobiliaria
    {
        private static List<ClienteComp> _listaClienteComp = new List<ClienteComp>();
        private static List<ClienteVenta> _listaClienteVenta = new List<ClienteVenta>();
        private static List<Venta> _listaVenta = new List<Venta>();
        private static List<Casa> _listaPropiedadesCasa = new List<Casa>();
        private static List<Apartamento> _listaPropiedadesApa = new List<Apartamento>();

        public List<ClienteComp> ListaClienteComps()
        {
            return _listaClienteComp;
        }
        public List<ClienteVenta> ListaClienteVenta()
        {
            return _listaClienteVenta;
        }
        public List<Venta> ListaVenta()
        {
            return _listaVenta;
        }
        public List<Casa> ListaPropiedadesCasa()
        {
            return _listaPropiedadesCasa;
        }
        public List<Apartamento> ListaPropiedadesApa() 
        {
            return _listaPropiedadesApa;
        }

        public ClienteVenta buscarClienteVenta(short pId)
        {
            foreach(ClienteVenta unClienteVenta in _listaClienteVenta)
            {
                if (unClienteVenta.Id.Equals(pId))
                    return unClienteVenta;
            }
            return null;
        }
        public ClienteComp buscarClienteComp(short pId)
        {
            foreach(ClienteComp unClienteComp in _listaClienteComp)
            {
                if (unClienteComp.Id.Equals(pId))
                    return unClienteComp;
            }
            return null;

        }

        public Casa buscarPropiedadCasa(short pId)
        {
            foreach(Casa unaCasa in _listaPropiedadesCasa)
            {
                if (unaCasa.Id.Equals(pId))
                    return unaCasa;

            }
            return null;
        }
        public Apartamento buscarPropiedadApa(short pId)
        {
            foreach (Apartamento unApa in _listaPropiedadesApa)
            {
                if (unApa.Id.Equals(pId))
                    return unApa;

            }
            return null;
        }

        public Venta buscarVenta(short pId)
        {
            foreach (Venta unaVenta in _listaVenta)
            {
                if (unaVenta.Id.Equals(pId))
                    return unaVenta;
            }
            return null;

        }

        public bool VentaAlta(Venta pVenta)
        {
            Venta unaVenta = this.buscarVenta(pVenta.Id);
            if(unaVenta == null)
            {
                _listaVenta.Add(pVenta);
                return true;

            }
            return false;
        }

        public bool PropiedadCasaAlta(Casa pCasa)
        {
            Casa unaCasa = this.buscarPropiedadCasa(pCasa.Id);
            if (unaCasa == null)
            {
                _listaPropiedadesCasa.Add(pCasa);
                return true;
            }
            else
                return false;
        }

        public bool PropiedadApaAlta(Apartamento pAprtamento)
        {
            Apartamento unaApa = this.buscarPropiedadApa(pAprtamento.Id);
            if (unaApa == null)
            {
                _listaPropiedadesApa.Add(pAprtamento);
                return true;
            }
            else
                return false;
        }
        public bool ClienteVentaAlta(ClienteVenta pClienteVenta)
        {
            ClienteVenta unClienteVenta = this.buscarClienteVenta(pClienteVenta.Id);
            if (unClienteVenta == null)
            {
                _listaClienteVenta.Add(pClienteVenta);
                return true;
            }
            else
               return false;
        }

        public bool ClienteCompAlta(ClienteComp pClienteComp)
        {
            ClienteComp unClienteComp = this.buscarClienteComp(pClienteComp.Id);
            if (unClienteComp == null)
            {
                _listaClienteComp.Add(pClienteComp);
                return true;
            }
            else
                return false;
        }


        public bool BajaVenta(short pId)
        {
            Venta unaVenta = buscarVenta(pId);
            if (unaVenta != null)
            {
                _listaVenta.Remove(unaVenta);
                return true;
            }
            else
                return false;
              
        }

        public bool PropiedadCasaBaja(short pId)
        {
            Casa unaCasa = buscarPropiedadCasa(pId);
            if (unaCasa != null)
            {
                _listaPropiedadesCasa.Remove(unaCasa);
                return true;
            }
            else
                return false;

        }

        public bool PropiedadApaBaja(short pId)
        {
            Apartamento unaApa = buscarPropiedadApa(pId);
            if (unaApa != null)
            {
                _listaPropiedadesApa.Remove(unaApa);
                return true;
            }
            else
                return false;

        }

        public bool ClienteVentaBaja(short pId)
        {
            ClienteVenta unClienteVenta = buscarClienteVenta(pId);
            if (unClienteVenta != null)
            {
                _listaClienteVenta.Remove(unClienteVenta);
                return true;
            }
            else
                return false;
        }


        public bool ClienteCompBaja(short pId)
        {
            ClienteComp unClienteComp = buscarClienteComp(pId);
            if (unClienteComp != null)
            {
                _listaClienteComp.Remove(unClienteComp);
                return true;
            }
            else
                return false;

        }

        
        public bool ModificarPropCasa(short pId, Boolean pGaraje, string pDirrecion, string pCiudad, string pBarrio, short pM2, ClienteVenta pClienteVenta, Boolean pPatio, Boolean pBarbaco)
        {
           Casa unaCasa = buscarPropiedadCasa(pId);
            if (unaCasa != null)
            {
                unaCasa.Id = pId;
                unaCasa.Dirrecion = pDirrecion;
                unaCasa.Garaje = pGaraje;
                unaCasa.Ciudad = pCiudad;
                unaCasa.Barrio = pBarrio;
                unaCasa.M2 = pM2;
                unaCasa.Patio = pPatio;
                unaCasa.Barbaco = pBarbaco;
                unaCasa.ClienteVenta = pClienteVenta;
                return true;
            }
            else
                return false;
        
        }
       
        public bool ModificarPropApa(short pId, Boolean pGaraje, string pDirrecion, string pCiudad, string pBarrio, short pM2, ClienteVenta pClienteVenta, short pNum)
        {
            Apartamento unaApa = buscarPropiedadApa(pId);
            if (unaApa != null)
            {
                unaApa.Id = pId;
                unaApa.Dirrecion = pDirrecion;
                unaApa.Garaje = pGaraje;
                unaApa.Ciudad = pCiudad;
                unaApa.Barrio = pBarrio;
                unaApa.M2 = pM2;
                unaApa.Num = pNum;
                unaApa.ClienteVenta = pClienteVenta;
                return true;
            }
            else
                return false;

        }


        public bool ModificarCliComp(short pId, string pNombre, string pApellido, int pTelefono, int pCedula)
        {
            ClienteComp unClienteComp = buscarClienteComp(pId);
            if (unClienteComp != null)
            {
                unClienteComp.Id = pId;
                unClienteComp.Nombre = pNombre;
                unClienteComp.Apellido = pApellido;
                unClienteComp.Telefono = pTelefono;
                unClienteComp.Cedula = pCedula;
                return true;
            }
            else
                return false;
        
        }

        public bool ModificarCliVen(short pId, string pNombre, string pApellido, int pTelefono, int pCedula)
        {
            ClienteVenta unClienteVenta = buscarClienteVenta(pId);
            if (unClienteVenta != null)
            {
                unClienteVenta.Id = pId;
                unClienteVenta.Nombre = pNombre;
                unClienteVenta.Apellido = pApellido;
                unClienteVenta.Telefono = pTelefono;
                unClienteVenta.Cedula = pCedula;
                return true;
            }
            else
                return false;

        }

        public List<Casa> ListaCasaOrdPorNombre()
        {
            List<Casa> CasaOrd = new List<Casa>(_listaPropiedadesCasa);
            Casa auxCas;
            for(int i = 0; i<CasaOrd.Count; i++)
            {
                for(int j = 0; j<CasaOrd.Count -1; j++)
                {
                    if(CasaOrd[j].Ciudad.ToUpper().CompareTo(CasaOrd[j+1].Ciudad.ToUpper())>0)
                    {
                        auxCas = CasaOrd[j];
                        CasaOrd[j] = CasaOrd[j + 1];
                        CasaOrd[j + 1] = auxCas;

                    }

                }
            }
            return CasaOrd;

        }

        public List<Apartamento> ListaPropApaPorCiudad()
        {
            List<Apartamento> ApaOrd = new List<Apartamento>(_listaPropiedadesApa);
            Apartamento auxApa;
            for(int i=0; i<ApaOrd.Count; i++)
            {
                for(int j=0; j<ApaOrd.Count -1; j++)
                {
                    if (ApaOrd[j].Ciudad.ToUpper().CompareTo(ApaOrd[j + 1].Ciudad.ToUpper()) > 0)
                    {
                        auxApa = ApaOrd[j];
                        ApaOrd[j] = ApaOrd[j + 1];
                        ApaOrd[j + 1] = auxApa;
                    }
                }

            }
            return ApaOrd;
        }

        public List<ClienteComp> CliOrdApellido()
        {
            List<ClienteComp> clienteCompsOrd = new List<ClienteComp>(_listaClienteComp);
            ClienteComp auxCli;
            for(int i=0; i<clienteCompsOrd.Count; i++)
            {
                for(int j =0; j<clienteCompsOrd.Count-1; j++)
                {
                    if(clienteCompsOrd[j].Apellido.ToUpper().CompareTo(clienteCompsOrd[j+1].Apellido.ToUpper())>0)
                    {
                        auxCli = clienteCompsOrd[j];
                        clienteCompsOrd[j] = clienteCompsOrd[j + 1];
                        clienteCompsOrd[j + 1] = auxCli;
                    }
                }
            }
            return clienteCompsOrd;

        }

        public List<ClienteVenta> CliOrdVenApellido()
        {
            List<ClienteVenta> clienteVentOrd = new List<ClienteVenta>(_listaClienteVenta);
            ClienteVenta auxCli;
            for (int i = 0; i < clienteVentOrd.Count; i++)
            {
                for (int j = 0; j < clienteVentOrd.Count - 1; j++)
                {
                    if (clienteVentOrd[j].Apellido.ToUpper().CompareTo(clienteVentOrd[j + 1].Apellido.ToUpper()) > 0)
                    {
                        auxCli = clienteVentOrd[j];
                        clienteVentOrd[j] = clienteVentOrd[j + 1];
                        clienteVentOrd[j + 1] = auxCli;
                    }
                }
            }
            return clienteVentOrd;

        }


        public List<ClienteComp> CedulaCompRegistro(int pCedula)
        {
            List<ClienteComp> CliDadCed = new List<ClienteComp>();
            ClienteComp unClienteComp = this.buscarClienteCed(pCedula);
            
            if (unClienteComp != null)
            {
               
                CliDadCed.Add(unClienteComp);
                return CliDadCed;
                
            }
            else
                return null;
        }


        public List<Venta> VentaClienteCompCed(int pCedula) 
        {
            ClienteComp unClienteComp = this.buscarClienteCed(pCedula);
           List<Venta> CliCompVen = this.buscarVentClienComp(unClienteComp);
            if (CliCompVen != null)
            {
                
                return CliCompVen;
            }
            else
                return null;
        }

        public List<Venta> buscarVentClienComp(ClienteComp pClienteComp)
        {
            List<Venta> CliCompVen = new List<Venta>();
            foreach(Venta unaVenta in _listaVenta)
            {
                if(unaVenta.ClienteComp.Equals(pClienteComp))
                {
                    CliCompVen.Add(unaVenta);
                    
                }
                
            }
            return CliCompVen;
           
            
        }   


        public ClienteComp buscarClienteCed(int pCedula)
        {
            foreach (ClienteComp unaClienteComp in _listaClienteComp)
            {
                if (unaClienteComp.Cedula.Equals(pCedula))
                {
                    return unaClienteComp;
                }
            }
                return null;
            
        }


        public List<ClienteVenta> CedulaVentRegistro(int pCedula)
        {
            List<ClienteVenta> CliVenDadCed = new List<ClienteVenta>();
            ClienteVenta unClienteVenta = this.BuscarClientCedVent(pCedula);
            if (unClienteVenta != null)
            {
                CliVenDadCed.Add(unClienteVenta);
                return CliVenDadCed;

            }
            else
                return null;
        }
        public List<Venta> VentaClienteVenCedCasa(int pCedula)
        {
            ClienteVenta clienteVenta = this.BuscarClientCedVent(pCedula);
            List<Venta> CliVendVenCasa = this.buscarClienteVenVentaCedCasa(clienteVenta);
            if (CliVendVenCasa != null)
            {
                return CliVendVenCasa;
            }
            else
                return null;

        }

        public List<Venta> buscarClienteVenVentaCedCasa(ClienteVenta pClienteVenta)
        {
            List<Venta> CliVendVenCasa = new List<Venta>();
            foreach(Venta unaVenta in _listaVenta)
            {
                if(unaVenta.Casa != null)
                {
                    if (unaVenta.Casa.ClienteVenta.Equals(pClienteVenta))
                    {
                        CliVendVenCasa.Add(unaVenta);
                    }
                }
            }
            return CliVendVenCasa;
        }

        public List<Venta> VentaClienteVenCedApa(int pCedula)
        {
            ClienteVenta unClienteVen = this.BuscarClientCedVent(pCedula);
            List<Venta> CliVendVenApa = this.buscarClienteVenVentaCedApa(unClienteVen);
            if (CliVendVenApa != null)
            { 
                return CliVendVenApa;
            }
            else
                return null;
        }

        

        public List<Venta> buscarClienteVenVentaCedApa(ClienteVenta pClienteVenta)
        {
            List<Venta> CliVendVenApa = new List<Venta>();
            foreach (Venta unaVenta in _listaVenta)
            {
                if (unaVenta.Apartamento != null)
                {
                    if (unaVenta.Apartamento.ClienteVenta.Equals(pClienteVenta))
                    {
                        CliVendVenApa.Add(unaVenta);
                    }
                }
            }
            return CliVendVenApa;

        }


        public ClienteVenta BuscarClientCedVent(int pCedula)
        {
            foreach(ClienteVenta unaClienteVenta in _listaClienteVenta)
            {
                if(unaClienteVenta.Cedula.Equals(pCedula))
                {
                    return unaClienteVenta;
                }
            }
            return null;

        }
    }


}
