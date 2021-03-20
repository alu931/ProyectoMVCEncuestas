using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
namespace WebMvcLab.Models
{
    public class EmpleadoEdit
    {
        public EmpleadoEntity empleado { get; set; }


        public List<TipoIndentificacionEntity> ddlTipoIdentificacion { get; set; }

        public List<EmpresaEntity> ddlEmpresa { get; set; }
    }
}