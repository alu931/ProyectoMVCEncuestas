using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class CantonEntity:EN
    {
        public int? IdCanton { get; set; }

        public int? IdProvincia { get; set; }
        public ProvinciaEntity Provincia { get; set; }

        public string Descripcion { get; set; }

        public CantonEntity()
        {
            Provincia = Provincia ?? new ProvinciaEntity();
        }
    }
}
