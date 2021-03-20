using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WBL;
using Entity;
using System.Web.Mvc;

namespace WebMvcLab
{
    public struct IApp
    {
        public static IEmpresaService empresaService => new EmpresaService();

        public static IEmpleadoService empleadoService => new EmpleadoService();

        public static ITipoIdentificacionService tipoidentificacionService => new TipoIdentificacionService();


        public static UsuarioEntity UsuarioSesion => HttpContext.Current.Session["UsuarioSession"] as UsuarioEntity ?? new UsuarioEntity();


        
    }



    public static class SessionExtension
    {

        public static void SessionOnline(this Controller ct)
        {
            if (!IApp.UsuarioSesion.IdUsuario.HasValue)
            {
                ct.Response.Redirect("/Login");
                ct.Response.Flush() ;
            }
        }
    }

}