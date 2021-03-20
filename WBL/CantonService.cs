using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICantonService : IDisposable
    {
        List<CantonEntity> ObtenerDll(EmpleadoEncuestaEntity entity);
    }
   public class CantonService: ICantonService
    {

        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }



        public List<CantonEntity> ObtenerDll(EmpleadoEncuestaEntity entity)
        {
            try
            {
                var result = sql.Query<CantonEntity>("CantonLista",new { 
                entity.IdProvincia
                });

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
