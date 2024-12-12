using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LibraryManagement.Entities;

public class Emprestimo:Entity<int>
{
    public int ExemplarId { get; set; }
    public virtual Exemplar Exemplar { get; set; }

    public string UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }


    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
    public int StatusEmprestimo { get; set; }

    public ICollection<Devolucao> Devolucoes { get; set; }
}
