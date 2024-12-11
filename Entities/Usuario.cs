using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Usuario:Entity<int>
    {
        [Key]
        [MaxLength(11)]
        public string CPFUsuario { get; set; }

        [Required]
        [MaxLength(80)]
        public string NomeUsuario { get; set; }

        [Required]
        public DateTime DataNascimentoUsuario { get; set; }

        [Required]
        [MaxLength(20)]
        public string TelefoneUsuario { get; set; }

        [ForeignKey("Endereco")]
        public int EnderecoID { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Devolucao> Devolucoes { get; set; }
    }
}