using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{

    public interface IEmpleadoEncuestaService : IDisposable
    {
        List<EmpleadoEncuestaEntity> ObtenerLista();
        DBEntity Insertar(EmpleadoEncuestaEntity entity);
    }
    public class EmpleadoEncuestaService: IEmpleadoEncuestaService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }



        public List<EmpleadoEncuestaEntity> ObtenerLista()
        {
            try
            {
                var result = sql.Query<EmpleadoEncuestaEntity,EmpleadoEntity,ProvinciaEntity,CantonEntity,DistritoEntity>("EmpleadoEncuestaObtener",
                    split: "IdEmpleado,IdProvincia,IdCanton,IdDistrito");

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public DBEntity Insertar(EmpleadoEncuestaEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("EmpleadoEncuestaInsertar", new
                {
                    entity.IdEmpleado,
                    entity.FechaNacimiento,
                    entity.EstadoCivil,
                    entity.LenguajeNativo,
                    entity.TieneHijos,
                    entity.CantidadHijos,
                    entity.CantidadHijosMantiene,
                    entity.Lee,
                    entity.Escribe,
                    entity.Carrera,
                    entity.MantienePersonasAparte,
                    entity.DesMantienePersonasAparte,
                    entity.IdProvincia,
                    entity.IdCanton,
                    entity.IdDistrito

                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


    }
}
