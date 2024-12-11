using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Genero:Entity<int>
    {
        [Required]
        [MaxLength(30)]
        public string NomeGenero { get; set; }

        public ICollection<LivroGenero> LivroGeneros { get; set; }
    }
}