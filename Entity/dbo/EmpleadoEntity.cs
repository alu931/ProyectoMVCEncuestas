using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class EmpleadoEntity:EN
    {
        public int? IdEmpleado { get; set; }
        public int? IdTipoIdentificacion { get; set; }
        //fK
        public TipoIndentificacionEntity TipoIndentificacion { get; set; }
        public int? IdEmpresa { get; set; }
        //fk
        public EmpresaEntity Empresa { get; set; }
        public string Identificacion { get; set; }
        public string NombreEmpleado { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public bool Estado { get; set; }
        public bool TieneVehiculo { get; set; }
        public string Vehiculos { get; set; }

        public EmpleadoEntity()
        {
            //depency injection manual
            Empresa = Empresa ?? new EmpresaEntity();
            TipoIndentificacion = TipoIndentificacion ?? new TipoIndentificacionEntity();
        }
    }
}
