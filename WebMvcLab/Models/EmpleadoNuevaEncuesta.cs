using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
namespace WebMvcLab.Models
{
    public class EmpleadoNuevaEncuesta
    {

        public EmpleadoEncuestaEntity EmpleadoEncuesta { get; set; } = new EmpleadoEncuestaEntity();

        public List<EmpleadoEntity> ddlEmpleados { get; set; }

        public List<ProvinciaEntity> ddlProvincias { get; set; }

    }
}