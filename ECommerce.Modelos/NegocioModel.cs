using System.ComponentModel.DataAnnotations;

namespace ECommerce.Modelos
{
    public class NegocioModel
    {
        [Key]
        public int NegocioId { get; set; }

        [Required(ErrorMessage ="El Nombre es obligatorio")]
        [MaxLength(60, ErrorMessage ="El nombre no debe superar los 60 caracteres")]
        public string Nombre { get; set;}

        [Required(ErrorMessage = "La descripción es obligatorio")]
        [MaxLength(100, ErrorMessage = "La descripción no debe superar los 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="El estado es obligatorio")]
        public bool Estado { get; set; }
    }
}
