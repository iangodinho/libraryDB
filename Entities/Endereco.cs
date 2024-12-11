using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Endereco:Entity<int>
    {
        [Required]
        [MaxLength(2)]
        public string UF { get; set; }
        public EstadosBrasileiros EstadosBrasileiros { get; set; }

        [Required]
        [MaxLength(80)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }

        [MaxLength(50)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(8)]
        public string CEP { get; set; }

        public ICollection<Biblioteca> Bibliotecas { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}