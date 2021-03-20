using DataAccess;
using Entity;
using System;
using System.Collections.Generic;

namespace WBL
{
    public interface ITipoIdentificacionService : IDisposable
    {
        List<TipoIndentificacionEntity> ObtenerLista(int? IdTipoIdentificacion);
        List<TipoIndentificacionEntity> Obtenerddl();
        DBEntity Insertar(TipoIndentificacionEntity entity);
        DBEntity Actualizar(TipoIndentificacionEntity entity);
        DBEntity Eliminar(TipoIndentificacionEntity entity);

    }
    public class TipoIdentificacionService : ITipoIdentificacionService
    {
        public IBD sql = new BD("Conn");
        public void Dispose()
        {
            sql = null;
        }


        public List<TipoIndentificacionEntity> ObtenerLista(int? IdTipoIdentificacion)
        {
            try
            {
                var result = sql.Query<TipoIndentificacionEntity>("TiposIdentificacionObtener", new
                {
                    IdTipoIdentificacion
                });
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<TipoIndentificacionEntity> Obtenerddl()
        {
            try
            {
                var result = sql.Query<TipoIndentificacionEntity>("TipoIdentificacionLista");
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public DBEntity Insertar(TipoIndentificacionEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("TiposIdentificacionInsertar", new
                {
                    entity.Descripcion,
                    entity.Estado

                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Actualizar(TipoIndentificacionEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("TipoIdentificacionActualizar", new
                {
                    entity.IdTipoIdentificacion,
                    entity.Descripcion,
                    entity.Estado

                });


                return result;
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        public DBEntity Eliminar(TipoIndentificacionEntity entity)
        {
            try
            {
                var result = sql.QueryExecute("TipoIdentificacionEliminar", new
                {
                    entity.IdTipoIdentificacion


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
