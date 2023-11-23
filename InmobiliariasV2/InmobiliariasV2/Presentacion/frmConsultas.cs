using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariasV2.Presentacion
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }
           private void Listar()
            {
                Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
                this.lstApart.DataSource = null;
                this.lstApart.DataSource = unaInmobiliaria.ListaPropApaPorCiudad();
                this.lstCasa.DataSource = null;
                this.lstCasa.DataSource = unaInmobiliaria.ListaCasaOrdPorNombre();


            }

      

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            int cedula = Convert.ToInt32(this.txtCedula.Text);
            this.lstCliCed.DataSource = null;
            this.lstVentasCli.DataSource = null;
            this.lstCliComVen.DataSource = null;
            this.lstCliVendVenApa.DataSource = null;
            this.LstCliVendVenCasa.DataSource = null;
            List<Dominio.ClienteComp> unClienteComp = unaInmobiliaria.CedulaCompRegistro(cedula);
            List<Dominio.ClienteVenta> unClienteVen = unaInmobiliaria.CedulaVentRegistro(cedula);
            List<Dominio.Venta> unVentaCliComp = unaInmobiliaria.VentaClienteCompCed(cedula);
            List<Dominio.Venta> unVentaCliVendApa = unaInmobiliaria.VentaClienteVenCedApa(cedula);
            List<Dominio.Venta> unVentaCliVendCasa = unaInmobiliaria.VentaClienteVenCedCasa(cedula);

            if(unVentaCliVendCasa.Count !=0)
            {
                this.LstCliVendVenCasa.DataSource = unaInmobiliaria.VentaClienteVenCedCasa(cedula);
            }
            if(unVentaCliVendCasa.Count ==0)
            {
                this.LstCliVendVenCasa.Items.Remove("No hay ventas de Casas de este cliente");
                this.LstCliVendVenCasa.Items.Add("No hay ventas de Casas de este cliente");
            }

            if (unVentaCliVendApa.Count != 0)
            {
                this.lstCliVendVenApa.DataSource = unaInmobiliaria.VentaClienteVenCedApa(cedula);

            }
            if(unVentaCliVendApa.Count ==0)
            {
                this.lstCliVendVenApa.Items.Remove("No hay ventas de apartamento de este Cliente");
                this.lstCliVendVenApa.Items.Add("No hay ventas de apartamento de este Cliente");
            }

            if (unVentaCliComp.Count !=0)
            {
                this.lstCliComVen.DataSource = unaInmobiliaria.VentaClienteCompCed(cedula);

            }
            if(unVentaCliComp.Count == 0)
            {
                this.lstCliComVen.Items.Remove("No hay Compras de este Cliente");
                this.lstCliComVen.Items.Add("No hay Compras de este Cliente");
            }

            if (unClienteComp != null)
            {
                this.lstCliCed.DataSource = unaInmobiliaria.CedulaCompRegistro(cedula);
            }
           if (unClienteVen != null)
            {
                this.lstVentasCli.DataSource = unaInmobiliaria.CedulaVentRegistro(cedula);
            }
            if(unClienteVen == null)
            {
                this.lstVentasCli.Items.Remove("No hay Clientes Vendedores");
                    this.lstVentasCli.Items.Add("No hay Clientes Vendedores");

            }
           if(unClienteComp ==null)
            {
                this.lstCliCed.Items.Remove("No hay Clientes Compradores");
                this.lstCliCed.Items.Add("No hay Clientes Compradores");
            } 
          
                

        }
    }
}
