using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class AutorLivro
    {
        [ForeignKey("Livro")]
        public int ISBN { get; set; }
        public Livro Livro { get; set; }

        [ForeignKey("Autor")]
        public int AutorID { get; set; }
        public Autor Autor { get; set; }
    }
}