using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Usuario:Entity<int>
    {
        public string CPFUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DataNascimentoUsuario { get; set; }
        public string TelefoneUsuario { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Devolucao> Devolucoes { get; set; }
    }
}