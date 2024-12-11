using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Exemplar:Entity<int>
    {
        [ForeignKey("Livro")]
        public int ISBN { get; set; }
        public Livro Livro { get; set; }

        [Required]
        public int Status { get; set; }

        [ForeignKey("Biblioteca")]
        public int BibliotecaID { get; set; }
        public Biblioteca Biblioteca { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Devolucao> Devolucoes { get; set; }
    }
}