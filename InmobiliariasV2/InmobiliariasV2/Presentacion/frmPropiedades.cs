using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariasV2.Presentacion
{
    public partial class frmPropiedades : Form
    {
        public frmPropiedades()
        {
            InitializeComponent();
        }
          private bool FaltanDatos()
            {
                if (this.txtId.Text == "" || this.txtDirr.Text == "" || this.txtBarrio.Text == "" || this.txtM2.Text == "" || this.txtCliVended.Text =="")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        private void CargarCasa(short pId)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            Dominio.Casa unaCasa = unaInmobiliaria.buscarPropiedadCasa(pId);

            this.txtId.Text = Convert.ToString(unaCasa.Id);
            this.txtDirr.Text = unaCasa.Dirrecion;
            this.txtBarrio.Text = unaCasa.Barrio;
            this.chkGaraje.Checked = unaCasa.Garaje;
            this.txtM2.Text = Convert.ToString(unaCasa.M2);
            this.chkPatio.Checked = unaCasa.Patio;
            this.chkBarbacoa.Checked = unaCasa.Barbaco;
            this.txtCliVended.Text = unaCasa.ClienteVenta.ToString();
            this.txtCiudad.Text = unaCasa.Ciudad;
        }
        private void CargarApa(short pId)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            Dominio.Apartamento unApa = unaInmobiliaria.buscarPropiedadApa(pId);

            this.txtId.Text = Convert.ToString(unApa.Id);
            this.txtDirr.Text = unApa.Dirrecion;
            this.txtBarrio.Text = unApa.Barrio;
            this.chkGaraje.Checked = unApa.Garaje;
            this.txtM2.Text = Convert.ToString(unApa.M2);
            this.txtNum.Text = Convert.ToString(unApa.Num);
            this.txtCliVended.Text = unApa.ClienteVenta.ToString();
            this.txtCiudad.Text = unApa.Ciudad;
        }
        private void CargarClienteVenta(short pId)
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            Dominio.ClienteVenta unClienteVenta = inmobiliaria.buscarClienteVenta(pId);
            this.txtCliVended.Text = unClienteVenta.ToString();
        }


        private void ListarCliVenta()
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            this.lstClienteVenta.DataSource = null;
            this.lstClienteVenta.DataSource = unaInmobiliaria.ListaClienteVenta();
        }

        private void ListarCasa()
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            this.lstCasa.DataSource = null;
            this.lstCasa.DataSource = inmobiliaria.ListaPropiedadesCasa();
        }

        private void ListarApa()
        {
            Dominio.Inmobiliaria inmobiliaria = new Dominio.Inmobiliaria();
            this.lstApar.DataSource = null;
            this.lstApar.DataSource = inmobiliaria.ListaPropiedadesApa();
        }

        private void limpiar()
        {
            this.txtId.Clear();
            this.txtDirr.Clear();
            this.txtBarrio.Clear();
            this.txtM2.Clear();
            this.txtCiudad.Clear();
            this.chkGaraje.Checked = false;
            this.chkBarbacoa.Checked = false;
            this.chkPatio.Checked = false;
            this.txtNum.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void frmPropiedades_Load(object sender, EventArgs e)
        {
            this.ListarCliVenta();
            this.ListarCasa();
            this.ListarApa();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();

            Dominio.Casa unaCasa = null;
            Dominio.Apartamento unApa = null;
            if(!FaltanDatos())
            {
                Dominio.ClienteVenta unCilenteVen = this.CliVenSelect();
                short id = Convert.ToInt16(this.txtId.Text);
                string dirrecion = this.txtDirr.Text;
                Boolean garaje = this.chkGaraje.Checked;
                string ciudad = this.txtCiudad.Text;
                string barrio = this.txtBarrio.Text;
                short M2 = Convert.ToInt16(this.txtM2.Text);
                if(rbdCasa.Checked)
                {
                    Boolean patio = this.chkPatio.Checked;
                    Boolean barbaco = this.chkBarbacoa.Checked;
                    unaCasa = new Dominio.Casa(id, garaje, dirrecion, ciudad, barrio, M2, unCilenteVen, patio, barbaco);
                    if(unaInmobiliaria.PropiedadCasaAlta(unaCasa))
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "Casa ingresada con exito";
                        this.ListarCasa();

                    }
                    else 
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "Casa ya existe";
                    }

                }
                else if(rbdApartamento.Checked)
                {
                    short num = Convert.ToInt16(this.txtNum.Text);
                    unApa = new Dominio.Apartamento(id, garaje, dirrecion, ciudad, barrio, M2, unCilenteVen, num);
                    if(unaInmobiliaria.PropiedadApaAlta(unApa))
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "Apartamento ingresado con exito";
                        this.ListarApa();

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "Apartamento ya existe";

                    }


                }
            }
        }

      
        private Dominio.ClienteVenta CliVenSelect()
        {
            if (this.txtCliVended.Text != "")
            {
                Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
                string CliSt = this.txtCliVended.ToString();
                string[] CliArr = CliSt.Split(' ');
                short ClinteVentaId = short.Parse(CliArr[2]);
                Dominio.ClienteVenta vec = unaInmobiliaria.buscarClienteVenta(ClinteVentaId);
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


        private void lstCasa_Click(object sender, EventArgs e)
        {
            byte numero = Convert.ToByte(this.lstCasa.SelectedIndex);
            string linea = this.lstCasa.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarCasa(id);
            rbdCasa.Checked = true;
        }

        private void lstApar_Click(object sender, EventArgs e)
        {
            byte numero = Convert.ToByte(this.lstApar.SelectedIndex);
            string linea = this.lstApar.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarApa(id);
            rbdApartamento.Checked = true;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            if(!FaltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                if(rbdApartamento.Checked)
                {
                    if(unaInmobiliaria.PropiedadApaBaja(id))
                    {
                        this.limpiar();
                        this.ListarApa();
                        this.lblMensajes.Text = "Apartamento eliminado con exito";

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se elimino el Apartamento, no se eoncontro";
                    }

                }
                else if(rbdCasa.Checked)
                {
                    if(unaInmobiliaria.PropiedadCasaBaja(id))
                    {
                        this.limpiar();
                        this.ListarCasa();
                        this.lblMensajes.Text = "Casa eliminada con exito";

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se elimino la Casa, no se eoncontro";
                    }

                }
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!FaltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                string dirrecion = this.txtDirr.Text;
                Boolean garaje = this.chkGaraje.Checked;
                string ciudad = this.txtCiudad.Text;
                string barrio = this.txtBarrio.Text;
                short m2 = Convert.ToInt16(this.txtM2.Text);
                Dominio.Inmobiliaria unaInmobiliara = new Dominio.Inmobiliaria();
                Dominio.ClienteVenta unCilenteVen = this.CliVenSelect();
                if (this.rbdApartamento.Checked)
                {
                    short num = Convert.ToInt16(this.txtNum.Text);
                    if (unaInmobiliara.ModificarPropApa(id, garaje, dirrecion, ciudad, barrio, m2, unCilenteVen, num))
                    {
                        this.limpiar();
                        this.ListarApa();
                        this.lblMensajes.Text = "Apartamento modificado";
                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se puedo modificar el Apartamento";

                    }
                }
                else if (this.rbdCasa.Checked)
                {
                    Boolean patio = this.chkPatio.Checked;
                    Boolean barbaco = this.chkBarbacoa.Checked;
                    if(unaInmobiliara.ModificarPropCasa(id, garaje, dirrecion, ciudad, barrio, m2, unCilenteVen,patio, barbaco))
                    {
                        this.limpiar();
                        this.ListarCasa();
                        this.lblMensajes.Text = "Casa modificado";
                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se puedo modificar la Casa";

                    }

                }

            }
        }

        private void rbdCasa_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbdCasa.Checked)
            {
                this.gbpBarPat.Visible = true;
               
            }
            else
            {
                this.gbpBarPat.Visible = false;
            }
        }

        private void rbdApartamento_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbdApartamento.Checked)
            {
                this.gpbNum.Visible = true;
            }
            else
            {
                this.gpbNum.Visible = false;
            }
        }

        private void lstClienteVenta_Click(object sender, EventArgs e)
        {
            string linea = this.lstClienteVenta.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idVehiculo = short.Parse(partes[0]);
            this.CargarClienteVenta(idVehiculo);
        }
    }
}
