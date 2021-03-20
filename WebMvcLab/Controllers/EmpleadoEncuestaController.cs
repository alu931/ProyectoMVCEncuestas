using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WBL;
using Entity;
using WebMvcLab.Models;
namespace WebMvcLab.Controllers
{
    public class EmpleadoEncuestaController : Controller
    {

        private readonly IProvinciaService ProvinciaService;
        private readonly ICantonService CantonService;
        private readonly IDistritoService DistritoService;
        private readonly IEmpleadoEncuestaService EmpleadoEncuestaService;
        private readonly IEmpleadoService EmpleadoService;

        public EmpleadoEncuestaController(IProvinciaService provinciaService, ICantonService cantonService, IDistritoService distritoService, IEmpleadoEncuestaService empleadoEncuestaService, IEmpleadoService empleadoService)
        {
            ProvinciaService = provinciaService;
            CantonService = cantonService;
            DistritoService = distritoService;
            EmpleadoEncuestaService = empleadoEncuestaService;
            EmpleadoService = empleadoService;
        }


        // GET: EmpleadoEncuesta
        public ActionResult Index()
        {
            this.SessionOnline();
            return View(EmpleadoEncuestaService.ObtenerLista());
        }

        public ActionResult NuevaEncuesta()
        {
            this.SessionOnline();

            var entity = new EmpleadoNuevaEncuesta();
            try
            {

                entity.ddlEmpleados = EmpleadoService.ObtenerLista(null);
                entity.ddlProvincias = ProvinciaService.ObtenerDll();


            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

            return View(entity);
        }




        [HttpPost]
        public ActionResult Save(EmpleadoEncuestaEntity entity)
        {
            try
            {
                var result = new DBEntity();

                result = EmpleadoEncuestaService.Insertar(entity);

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult ddlCanton(EmpleadoEncuestaEntity entity)
        {
            try
            {
                var result = new List<CantonEntity>();

                result = CantonService.ObtenerDll(entity);

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new List<CantonEntity>());
            }
        }


        [HttpPost]
        public ActionResult ddlDistrito(EmpleadoEncuestaEntity entity)
        {
            try
            {
                var result = new List<DistritoEntity>();

                result = DistritoService.ObtenerDll(entity);

                return Json(result);
            }
            catch (Exception ex)
            {

                return Json(new List<DistritoEntity>());
            }
        }



    }
}