using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariasV2.Presentacion
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtTelefono.Clear();
            this.txtCedula.Clear();
            this.lblMensajes.Text ="";
            this.txtId.Focus();
        }
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == ""|| this.txtTelefono.Text =="" || this.txtCedula.Text =="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool ordenCli = false;
        private void listar()
        {
            if (ordenCli)
            {
                ListarOrd();
            }
            else 
            {
                ListarIng();
            }

        }

        private void ListarOrd()
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            this.lstClienteVenta.DataSource = null;
            this.lstClienteVenta.DataSource = unaInmobiliaria.CliOrdVenApellido();
            this.lstClienteComp.DataSource = null;
            this.lstClienteComp.DataSource = unaInmobiliaria.CliOrdApellido();
            ordenCli = true;
        }
        private void ListarIng()
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            this.lstClienteVenta.DataSource = null;
            this.lstClienteVenta.DataSource = unaInmobiliaria.ListaClienteVenta();
            this.lstClienteComp.DataSource = null;
            this.lstClienteComp.DataSource = unaInmobiliaria.ListaClienteComps();
            ordenCli = false;
        }

        private void CargarComp(short pId)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            Dominio.ClienteComp unCliComp = unaInmobiliaria.buscarClienteComp(pId);

            this.txtId.Text = Convert.ToString(unCliComp.Id);
            this.txtNombre.Text = unCliComp.Nombre;
            this.txtApellido.Text = unCliComp.Apellido;
            this.txtTelefono.Text = Convert.ToString(unCliComp.Telefono);
            this.txtCedula.Text = Convert.ToString(unCliComp.Cedula);

        }

        private void CargarVent(short pId)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();
            Dominio.ClienteVenta unCliVen = unaInmobiliaria.buscarClienteVenta(pId);

            this.txtId.Text = Convert.ToString(unCliVen.Id);
            this.txtNombre.Text = unCliVen.Nombre;
            this.txtApellido.Text = unCliVen.Apellido;
            this.txtTelefono.Text = Convert.ToString(unCliVen.Telefono);
            this.txtCedula.Text = Convert.ToString(unCliVen.Cedula);

        }

     



        private void btnAlta_Click(object sender, EventArgs e)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();

            Dominio.ClienteVenta unClienteVenta = null;
            Dominio.ClienteComp unClienteComp = null;

            if(!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                int telefono = Convert.ToInt32(this.txtTelefono.Text);
                int Cedula = Convert.ToInt32(this.txtCedula.Text);
                if (rbdClienteComprador.Checked)
                {
                    unClienteComp = new Dominio.ClienteComp(id, nombre, apellido, telefono, Cedula);
                    if (unaInmobiliaria.ClienteCompAlta(unClienteComp))
                    {
                        this.limpiar();
                        this.lblMensajes.Text ="Comprador ingresado con exito";
                        this.ListarIng();

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "ERROR, comprador ya existe";
                    }
                }
                else if (this.rbdClienteVenta.Checked)
                {
                    unClienteVenta = new Dominio.ClienteVenta(id, nombre, apellido, telefono, Cedula);
                    if (unaInmobiliaria.ClienteVentaAlta(unClienteVenta))
                    {
                        
                        this.limpiar();
                        this.lblMensajes.Text ="Vendedor ingresado con exito";
                        this.ListarIng();
                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "ERROR, vendedor ya existe";
                    }


                }



            }
        }

   
       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.listar();

        }

        private void lstClienteVenta_Click(object sender, EventArgs e)
        {
            byte numero = Convert.ToByte(this.lstClienteVenta.SelectedIndex);
            string linea = this.lstClienteVenta.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarVent(id);
        }
      

        private void lstClienteComp_Click(object sender, EventArgs e)
        {
            byte numero = Convert.ToByte(this.lstClienteComp.SelectedIndex);
            string linea = this.lstClienteComp.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short id = short.Parse(partes[0]);
            this.CargarComp(id);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Inmobiliaria unaInmobiliaria = new Dominio.Inmobiliaria();

            
            if (!this.faltanDatos())
            {
                short id = Convert.ToInt16(this.txtId.Text);

                if (rbdClienteComprador.Checked)
                {
                    if (unaInmobiliaria.ClienteCompBaja(id))
                    {
                        this.limpiar();
                        this.ListarIng();
                        this.lblMensajes.Text = "Comprador eliminado con exito";

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se elimino Comprador, no se eoncontro";
                    }
                }
                else if (rbdClienteVenta.Checked)
                {
                    if (unaInmobiliaria.ClienteVentaBaja(id))
                    {
                        this.limpiar();
                        this.ListarIng();
                        this.lblMensajes.Text = "Vendedor eliminado con exito";

                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se elimino Vendedor, no se eoncontro";
                    }
                }



            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!this.faltanDatos())
            { 
                short id = Convert.ToInt16(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                int telefono = Convert.ToInt32(this.txtTelefono.Text);
                int cedula = Convert.ToInt32(this.txtCedula.Text);
                Dominio.Inmobiliaria unaInmobiliara = new Dominio.Inmobiliaria();
                if (rbdClienteComprador.Checked)
                    {
                        if(unaInmobiliara.ModificarCliComp(id, nombre, apellido, telefono, cedula))
                        {
                            this.limpiar();
                            this.ListarIng();
                            this.lblMensajes.Text = "Comprador modificado";

                        }
                        else
                        {
                            this.limpiar();
                        this.lblMensajes.Text = "No se pudo modificar el comprador";
                        }
                    }
                else if(rbdClienteVenta.Checked)
                {
                    if(unaInmobiliara.ModificarCliVen(id, nombre, apellido, telefono, cedula))
                    {
                        this.limpiar();
                        this.ListarIng();
                        this.lblMensajes.Text = "Vendedor Modificado";
                    }
                    else
                    {
                        this.limpiar();
                        this.lblMensajes.Text = "No se pudo modificar el vendedor";

                    }
                }

            }
        }

        private void rbdOrdPorIng_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarIng();
        }

        private void rbdListOrdApll_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarOrd();
        }
    }
}
