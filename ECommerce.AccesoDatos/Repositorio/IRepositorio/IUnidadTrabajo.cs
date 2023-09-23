namespace ECommerce.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {

        // Añadiremos los repositorios añadidos para cada modelo

        INegocioRepositorio Negocio { get; }

        Task Save();
    }
}
