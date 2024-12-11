using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Autor:Entity<int>
    {
        [Required]
        [MaxLength(80)]
        public string NomeAutor { get; set; }

        public ICollection<AutorLivro> AutorLivros { get; set; }
    }
}