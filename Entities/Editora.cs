using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Editora:Entity<int>
    {
        [Required]
        [MaxLength(30)]
        public string NomeEditora { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cidade { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}