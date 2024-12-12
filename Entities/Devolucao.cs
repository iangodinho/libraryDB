using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Devolucao:Entity<int>
    {
        public int ExemplarId { get; set; }
        public Exemplar Exemplar { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int EmprestimoId { get; set; }
        public Emprestimo Emprestimo { get; set; }

        public DateTime DataDevolucao { get; set; }
    }
}