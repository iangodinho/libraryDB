using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class EstadosBrasileiros
    {
        [Key]
        [MaxLength(2)]
        public string UF { get; set; }

        [Required]
        [MaxLength(30)]
        public string Estado { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
    }
}