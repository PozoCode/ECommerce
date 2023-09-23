using ECommerce.Modelos;

namespace ECommerce.AccesoDatos.Repositorio.IRepositorio
{
    public interface INegocioRepositorio : IRepositorio<NegocioModel>
    {
        // Aquí van los métodos que necesitan ser tratados de forma individual para cada modelo

        void Update(NegocioModel negocio);
    }
}
