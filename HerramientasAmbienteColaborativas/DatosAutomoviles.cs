using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerramientasAmbienteColaborativas
{
    public class DatosAutomoviles
    {
        public List<DatoAutomovil> datosAutomoviles { set; get; }

        public DatosAutomoviles()
        {
            datosAutomoviles = new List<DatoAutomovil>();
        }
        public void Agregar(DatoAutomovil datoAutomovil)
        {
            datosAutomoviles.Add(datoAutomovil);
        }

        public List<DatoAutomovil> SegunMarcaDada(string cadena)
        {
            List<DatoAutomovil> segunMarca = new List<DatoAutomovil>();
            foreach (DatoAutomovil datoAutomovil in datosAutomoviles)
            {
                if (datoAutomovil.Marca.Equals(cadena))
                {
                    segunMarca.Add(datoAutomovil);
                }
            }
            return segunMarca;
        }
        public List<DatoAutomovil> PlacaIniciaCadena(string cadena)
        {
            List<DatoAutomovil> segunPlaca = new List<DatoAutomovil>();
            foreach (DatoAutomovil datoAutomovil in datosAutomoviles)
            {
                if (datoAutomovil.Placa.StartsWith(cadena))
                {
                    segunPlaca.Add(datoAutomovil);
                }
            }
            return segunPlaca;
        }
        public List<DatoAutomovil> ConductorFinalCadena(string cadena)
        {
            List<DatoAutomovil> segunConductor = new List<DatoAutomovil>();
            foreach (DatoAutomovil datoAutomovil in datosAutomoviles)
            {
                if (datoAutomovil.Conductor.EndsWith(cadena))
                {
                    segunConductor.Add(datoAutomovil);
                }
            }
            return segunConductor;
        }
    }
}
