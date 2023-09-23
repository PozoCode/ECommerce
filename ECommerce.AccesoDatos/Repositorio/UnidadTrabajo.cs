using ECommerce.AccesoDatos.Data;
using ECommerce.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _context;

        // Listaremos todos los IRepositorio que agregaremos para los modelos
        public INegocioRepositorio Negocio { get; private set; }

        public UnidadTrabajo(ApplicationDbContext context)
        {
            _context = context;
            Negocio = new NegocioRepositorio(_context);
            
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
