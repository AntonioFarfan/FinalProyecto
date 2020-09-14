using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerramientasAmbienteColaborativas
{
    public partial class Form3 : Form
    {
        public DatosAutomoviles automoviles { set; get; }
        public Form3()
        {
            InitializeComponent();
            automoviles = new DatosAutomoviles();
            OcultarMarca();
            OcultarPlaca();
            OcultarConductor();
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarMarca();
            OcultarPlaca();
            OcultarConductor();
            if (cmbMostrar.SelectedItem.Equals("Todos los automoviles"))
            {
                dgvAutomoviles.DataSource = automoviles.datosAutomoviles;
            }

            if (cmbMostrar.SelectedItem.Equals("Segun marca"))
            {
                txtMarca.Visible = true;
                lblMarca.Visible = true;
                btnMarca.Visible = true; ;
            }
            if (cmbMostrar.SelectedItem.Equals("Segun placa"))
            {
                txtPlaca.Visible = true;
                lblPlaca.Visible = true;
                btnPlaca.Visible = true;
            }
            if (cmbMostrar.SelectedItem.Equals("Segun dueño"))
            {
                txtConductor.Visible = true;
                lblConductor.Visible = true;
                btnConductor.Visible = true;
            }
        }
        public void OcultarConductor()
        {
            txtConductor.Visible = false;
            lblConductor.Visible = false;
            btnConductor.Visible = false;
        }
        public void OcultarPlaca()
        {
            txtPlaca.Visible = false;
            lblPlaca.Visible = false;
            btnPlaca.Visible = false;
        }
        public void OcultarMarca()
        {
            txtMarca.Visible = false;
            lblMarca.Visible = false;
            btnMarca.Visible = false;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            dgvAutomoviles.DataSource = automoviles.SegunMarcaDada(txtMarca.Text);
            txtMarca.Text = "";
        }

        private void btnPlaca_Click(object sender, EventArgs e)
        {
            
            dgvAutomoviles.DataSource = automoviles.PlacaIniciaCadena(txtPlaca.Text);
            txtPlaca.Text = "";
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            dgvAutomoviles.DataSource = automoviles.ConductorFinalCadena(txtConductor.Text);
            txtConductor.Text = "";
        }
    }
}
