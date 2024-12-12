using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Exemplar:Entity<int>
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int Status { get; set; }

        public int BibliotecaId { get; set; }
        public Biblioteca Biblioteca { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Devolucao> Devolucoes { get; set; }
    }
}