using ECommerce.AccesoDatos.Data;
using ECommerce.AccesoDatos.Repositorio.IRepositorio;
using ECommerce.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.AccesoDatos.Repositorio
{
    public class NegocioRepositorio : Repositorio<NegocioModel>, INegocioRepositorio
    {

        private readonly ApplicationDbContext _context;

        public NegocioRepositorio(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(NegocioModel negocio)
        {
            var negocioBD = _context.Negocio.FirstOrDefault(x => x.NegocioId == negocio.NegocioId);

            if (negocioBD !=  null)
            {
                negocioBD.Nombre = negocio.Nombre;
                negocioBD.Descripcion = negocio.Descripcion;
                negocioBD.Estado = negocio.Estado;

                _context.SaveChanges();
            }
        }
    }
}
