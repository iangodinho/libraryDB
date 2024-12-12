using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class EstadosBrasileiros:Entity<int>
    {
        public string UF { get; set; }
        public string Estado { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
    }
}