using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LibraryManagement.Entities;

public class Emprestimo:Entity<int>
{
    public int ExemplarID { get; set; }
    public virtual Exemplar Exemplar { get; set; }

    [ForeignKey("Usuario")]
    public string CPFUsuario { get; set; }
    public virtual Usuario Usuario { get; set; }

    [Required]
    public DateTime DataEmprestimo { get; set; }

    [Required]
    public DateTime DataDevolucao { get; set; }

    [Required]
    public int StatusEmprestimo { get; set; }

    public ICollection<Devolucao> Devolucoes { get; set; }
}
