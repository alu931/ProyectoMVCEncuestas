using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{

    public interface IDistritoService : IDisposable
    {
        List<DistritoEntity> ObtenerDll(EmpleadoEncuestaEntity entity);
    }
  public  class DistritoService: IDistritoService
    {

        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }



        public List<DistritoEntity> ObtenerDll(EmpleadoEncuestaEntity entity)
        {
            try
            {
                var result = sql.Query<DistritoEntity>("DistritoLista",
                    new { 
                     entity.IdCanton
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
