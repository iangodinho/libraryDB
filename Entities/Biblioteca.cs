using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Biblioteca:Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string NomeBiblioteca { get; set; }

        [Required]
        [MaxLength(11)]
        public string TelefoneBiblioteca { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailBiblioteca { get; set; }

        [ForeignKey("Endereco")]
        public int EnderecoID { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Exemplar> Exemplares { get; set; }
    }
}