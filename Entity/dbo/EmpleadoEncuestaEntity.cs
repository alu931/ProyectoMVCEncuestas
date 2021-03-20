using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmpleadoEncuestaEntity:EN
    {
      
        public int? IdEmpleadoEncuesta { get; set; }

        public int? IdEmpleado { get; set; }
        public EmpleadoEntity Empleado { get; set; }

        public string FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string LenguajeNativo { get; set; }
        public bool TieneHijos { get; set; }
        public int? CantidadHijos { get; set; }
        public int? CantidadHijosMantiene { get; set; }
        public bool Lee { get; set; }
        public bool Escribe { get; set; }
        public string Carrera { get; set; }
        public bool MantienePersonasAparte { get; set; }
        public string DesMantienePersonasAparte { get; set; }
        public int? IdProvincia { get; set; }
        public ProvinciaEntity Provincia { get; set; }
        public int? IdCanton { get; set; }
        public CantonEntity Canton { get; set; }
        public int? IdDistrito { get; set; }
        public DistritoEntity Distrito { get; set; }

        public EmpleadoEncuestaEntity()
        {
            Empleado = Empleado ?? new EmpleadoEntity();
            Provincia = Provincia ?? new ProvinciaEntity();
            Canton = Canton ?? new CantonEntity();
            Distrito = Distrito ?? new DistritoEntity();
        }




    }
}
