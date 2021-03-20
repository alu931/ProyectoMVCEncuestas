using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class DistritoEntity:EN
    {
        public int? IdDistrito { get; set; }

        public int? IdCanton { get; set; }
        public CantonEntity Canton { get; set; }

        public string Descripcion { get; set; }

        public DistritoEntity()
        {
            Canton = Canton ?? new CantonEntity();
        }

    }
}
