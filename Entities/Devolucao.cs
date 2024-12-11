using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Devolucao:Entity<int>
    {
        [ForeignKey("Exemplar")]
        public int ExemplarID { get; set; }
        public Exemplar Exemplar { get; set; }

        [MaxLength(11)]
        public string CPFUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Emprestimo")]
        public int EmprestimoID { get; set; }
        public Emprestimo Emprestimo { get; set; }

        [Required]
        public DateTime DataDevolucao { get; set; }
    }
}