using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariasV2.Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Singleton(string pNombreForm)
        {
            bool encontre = false;
            foreach (Form unFrm in this.MdiChildren)
            {
                if (unFrm.Name.Equals(pNombreForm))
                {
                    encontre = true;
                    unFrm.Show();

                }
            }
            if (!encontre)
            {
                switch (pNombreForm)
                {
                    case "frmCliente":
                        Presentacion.frmCliente unfrmC = new Presentacion.frmCliente();
                        unfrmC.MdiParent = this;
                        unfrmC.Show();
                        break;

                    case "frmPropiedades":
                        Presentacion.frmPropiedades unfrmP = new Presentacion.frmPropiedades();
                        unfrmP.MdiParent = this;
                        unfrmP.Show();
                        break;

                    case "frmVenta":
                        Presentacion.frmVenta unfrmV = new Presentacion.frmVenta();
                        unfrmV.MdiParent = this;
                        unfrmV.Show();
                        break;

                    case "frmConsultas":
                        Presentacion.frmConsultas unfrmCon = new Presentacion.frmConsultas();
                        unfrmCon.MdiParent = this;
                        unfrmCon.Show();
                        break;




                }
            }









        }


    

       

       

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmCliente";
            this.Singleton(nombreFrm);
        }

        private void mnuPropiedades_Click_1(object sender, EventArgs e)
        {
            string nombreFrm = "frmPropiedades";
            this.Singleton(nombreFrm);
        }

        private void mnuVentas_Click_1(object sender, EventArgs e)
        {
            string nombreFrm = "frmVenta";
            this.Singleton(nombreFrm);
        }

        private void mnuConsultas_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmConsultas";
            this.Singleton(nombreFrm);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
