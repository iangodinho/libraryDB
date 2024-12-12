using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Endereco:Entity<int>
    {


        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }

        public string EstadosBrasileirosId { get; set; }
        public EstadosBrasileiros EstadosBrasileiros { get; set; }

        public ICollection<Biblioteca> Bibliotecas { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}