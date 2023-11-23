using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariasV2.Presentacion
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtPrecio.Text == "" || this.txtComp.Text == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void ListarVent()
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            this.lstVentas.DataSource = null;
            this.lstVentas.DataSource = unaInmobiliaria.ListaVenta();

        }
        private void ListarComp()
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            this.lstComp.DataSource = null;
            this.lstComp.DataSource = unaInmobiliaria.ListaClienteComps();

        }
        private void ListarPropCasa()
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            this.lstPropCasa.DataSource = null;
            this.lstPropCasa.DataSource = inmobiliaria.ListaPropiedadesCasa();

        }
        private void ListarPropApa()
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            this.lstPropApa.DataSource = null;
            this.lstPropApa.DataSource = inmobiliaria.ListaPropiedadesApa();
        }
        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtPrecio.Clear();
            this.txtCasa.Clear();
            this.txtApa.Clear();
            this.txtComp.Clear();
            this.dteFecha.ResetText();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.ListarComp();
            this.ListarPropApa();
            this.ListarPropCasa();
            this.ListarVent();
        }
        private void CargarClienteComp(short pId)
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            Dominio.ClienteComp unClienteComp = inmobiliaria.buscarClienteComp(pId);
            this.txtComp.Text = unClienteComp.ToString();
        }
        private void CargarPropCasa(short pId)
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            Dominio.Casa unaCasa = inmobiliaria.buscarPropiedadCasa(pId);
            this.txtCasa.Text = unaCasa.ToString();

        }
        private void CargarPropApa(short pId)
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            Dominio.Apartamento unApa = inmobiliaria.buscarPropiedadApa(pId);
            this.txtApa.Text = unApa.ToString();

        }
        private void CargarVenta(short pId)
        {

            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            Dominio.Venta unaVenta = unaInmobiliaria.buscarVenta(pId);


            if (unaVenta.Apartamento == null)
            {
                this.txtId.Text = Convert.ToString(unaVenta.Id);
                this.txtPrecio.Text = Convert.ToString(unaVenta.Precio);
                this.dteFecha.Value = unaVenta.Fecha;
                this.txtComp.Text = unaVenta.ClienteComp.ToString();
                this.txtCasa.Text = unaVenta.Casa.ToString();

            }
             if (unaVenta.Casa == null)
            {
                this.txtId.Text = Convert.ToString(unaVenta.Id);
                this.txtPrecio.Text = Convert.ToString(unaVenta.Precio);
                this.dteFecha.Value = unaVenta.Fecha;
                this.txtComp.Text = unaVenta.ClienteComp.ToString();
                this.txtApa.Text = unaVenta.Apartamento.ToString();

            }
            if (unaVenta.Casa != null && unaVenta.Apartamento != null)
            {
                this.txtId.Text = Convert.ToString(unaVenta.Id);
                this.txtPrecio.Text = Convert.ToString(unaVenta.Precio);
                this.dteFecha.Value = unaVenta.Fecha;
                this.txtComp.Text = unaVenta.ClienteComp.ToString();
                this.txtCasa.Text = unaVenta.Casa.ToString();
                this.txtApa.Text = unaVenta.Apartamento.ToString();
            }
        }


        private Dominio.ClienteComp ClienteCompSelec()
        {
            if (this.txtComp.Text != "")
            {
                Dominio.Inmobiliaria unaAutomotora = new Dominio.Inmobiliaria();
                string socioSt = this.txtComp.ToString();
                string[] socioArr = socioSt.Split(' ');
                short ClienteCompId = short.Parse(socioArr[2]);
                Dominio.ClienteComp vec = unaAutomotora.buscarClienteComp(ClienteCompId);
                if (vec != null)
                {
                    return vec;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        private Dominio.Apartamento ApaSelec()
        {
            if (this.txtApa.Text != "")
            {
                Dominio.Inmobiliaria unaAutomotora = new Dominio.Inmobiliaria();
                string socioSt = this.txtApa.ToString();
                string[] socioArr = socioSt.Split(' ');
                short ClienteCompId = short.Parse(socioArr[2]);
                Dominio.Apartamento vec = unaAutomotora.buscarPropiedadApa(ClienteCompId);
                if (vec != null)
                {
                    return vec;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        private Dominio.Casa CasaSelec()
        {
            if (this.txtCasa.Text != "")
            {
                Dominio.Inmobiliaria unaAutomotora = new Dominio.Inmobiliaria();
                string socioSt = this.txtCasa.ToString();
                string[] socioArr = socioSt.Split(' ');
                short ClienteCompId = short.Parse(socioArr[2]);
                Dominio.Casa vec = unaAutomotora.buscarPropiedadCasa(ClienteCompId);
                if (vec != null)
                {
                    return vec;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

      

        private void lstPropCasa_Click(object sender, EventArgs e)
        {
            string linea = this.lstPropCasa.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idVehiculo = short.Parse(partes[0]);
            this.CargarPropCasa(idVehiculo);
        }

        private void lstPropApa_Click(object sender, EventArgs e)
        {
            string linea = this.lstPropApa.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idVehiculo = short.Parse(partes[0]);
            this.CargarPropApa(idVehiculo);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                if (txtApa.Text == "")
                {
                    Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
                    short id = Convert.ToInt16(this.txtId.Text);
                    DateTime Fecha = this.dteFecha.Value;
                    short precio = Convert.ToInt16(this.txtPrecio.Text);
                    Dominio.Casa Casa = this.CasaSelec();
                    Dominio.Apartamento apartamento = null;

                    Dominio.ClienteComp unComp = this.ClienteCompSelec();

                    Dominio.Venta unaVenta = new Dominio.Venta(id, Fecha, precio, Casa, apartamento, unComp);
                    if (unaInmobiliaria.VentaAlta(unaVenta))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Venta ingresada con exito";
                        this.ListarVent();

                    }
                    else
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Venta no se pudo realizar";
                    }
                }
                else if(txtCasa.Text == "")
                {
                    Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
                    short id = Convert.ToInt16(this.txtId.Text);
                    DateTime Fecha = this.dteFecha.Value;
                    short precio = Convert.ToInt16(this.txtPrecio.Text);
                    Dominio.Casa Casa = null;
                    Dominio.Apartamento apartamento = this.ApaSelec();

                    Dominio.ClienteComp unComp = this.ClienteCompSelec();

                    Dominio.Venta unaVenta = new Dominio.Venta(id, Fecha, precio, Casa, apartamento, unComp);
                    if (unaInmobiliaria.VentaAlta(unaVenta))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Venta ingresada con exito";
                        this.ListarVent();

                    }
                    else
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Venta no se pudo realizar";
                    }
                }
                else if(txtCasa.Text != "" && txtApa.Text !="")
                {
                    Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
                    short id = Convert.ToInt16(this.txtId.Text);
                    DateTime Fecha = this.dteFecha.Value;
                    short precio = Convert.ToInt16(this.txtPrecio.Text);
                    Dominio.Casa Casa = this.CasaSelec();
                    Dominio.Apartamento apartamento = this.ApaSelec();

                    Dominio.ClienteComp unComp = this.ClienteCompSelec();

                    Dominio.Venta unaVenta = new Dominio.Venta(id, Fecha, precio, Casa, apartamento, unComp);
                    if (unaInmobiliaria.VentaAlta(unaVenta))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Venta ingresada con exito";
                        this.ListarVent();

                    }
                    else
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Venta no se pudo realizar";
                    }
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            if(!faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                if (unaInmobiliaria.BajaVenta(id))
                {
                    this.Limpiar();
                    this.ListarVent();
                    this.lblMensajes.Text = "Venta eliminada con exito";

                }
                else
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "No se pudo eliminar la venta, no se eoncontro";
                }
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.ListarComp();
            this.ListarPropApa();
            this.ListarPropCasa();
            this.ListarVent();
        }

        private void lstVentas_Click(object sender, EventArgs e)
        {
            string linea = this.lstVentas.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idVehiculo = short.Parse(partes[0]);
            this.CargarVenta(idVehiculo);
        }

        private void lstComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string linea = this.lstComp.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idVehiculo = short.Parse(partes[0]);
            this.CargarClienteComp(idVehiculo);
        }
    }
}
