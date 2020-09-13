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
    }
}
