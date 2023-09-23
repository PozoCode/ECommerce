using ECommerce.AccesoDatos.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NegocioController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public NegocioController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        #region ObtenerTodos
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var negocios = await _unidadTrabajo.Negocio.GetAll();

            return View(negocios);
        }
        #endregion

    }
}