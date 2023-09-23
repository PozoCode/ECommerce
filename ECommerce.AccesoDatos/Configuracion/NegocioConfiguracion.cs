using ECommerce.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.AccesoDatos.Configuracion
{
    public class NegocioConfiguracion : IEntityTypeConfiguration<NegocioModel>
    {
        public void Configure(EntityTypeBuilder<NegocioModel> builder)
        {
            builder.Property(x => x.NegocioId);
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired();
        }
    }
}
