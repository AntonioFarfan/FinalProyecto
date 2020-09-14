using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerramientasAmbienteColaborativas
{
    public class DatoAutomovil
    {
        //Programacion II
        public string Conductor { set; get; }
        public string Modelo { set; get; }
        public string Marca { set; get; }
        public string Placa { set; get; }
        public int Kilometraje { set; get; }
        public string FechaCompra { set; get; }

        public DatoAutomovil()
        {
        }

        public DatoAutomovil(string conductor, string modelo, string marca, string placa, int kilometraje, string fechaCompra)
        {
            Conductor = conductor;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
            Kilometraje = kilometraje;
            FechaCompra = fechaCompra;
        }
    }
}
