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
    public partial class Form2 : Form
    {
        DatosAutomoviles automoviles = new DatosAutomoviles();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarInformacion())
                {
                    DatoAutomovil automovil = new DatoAutomovil();
                    automovil.Conductor = txtConductor.Text;
                    automovil.Marca = txtMarca.Text;
                    automovil.Modelo = txtModelo.Text;
                    automovil.Placa = txtPlaca.Text;
                    automovil.Kilometraje = Convert.ToInt32(mtxtKilometraje.Text);
                    automovil.FechaCompra = dtpFecha.Value.ToString();
                    automoviles.Agregar(automovil);
                    MessageBox.Show("Datos guardados correctamente.");
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Ingrese toda la información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarControles()
        {
            txtConductor.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            mtxtKilometraje.Text = "";
            dtpFecha.Value = DateTime.Now;
        }
        public bool VerificarInformacion()
        {
            bool verifica = false;
            if (txtConductor.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtPlaca.Text != "" && mtxtKilometraje.Text != "")
            {
                verifica = true;
            }
            return verifica;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3 = new Form3();
            form3.Show();
            //form3.automoviles = automoviles;
        }
    }
}
