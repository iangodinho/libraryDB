using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities.Canceladas
{
    public class LivroGenero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LivroGeneroID { get; set; }

        [ForeignKey("Genero")]
        public int GeneroID { get; set; }
        public Genero Genero { get; set; }

        [ForeignKey("Livro")]
        public int ISBN { get; set; }
        public Livro Livro { get; set; }
    }
}