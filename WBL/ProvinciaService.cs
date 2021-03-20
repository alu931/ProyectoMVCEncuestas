using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace WBL
{
    public interface IProvinciaService:IDisposable
    {
        List<ProvinciaEntity> ObtenerDll();
    }

    public class ProvinciaService: IProvinciaService
    {

        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<ProvinciaEntity> ObtenerDll()
        {
            try
            {
                var result = sql.Query<ProvinciaEntity>("ProvinciaLista");

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
