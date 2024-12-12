using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Biblioteca:Entity<int>
    {
        public string NomeBiblioteca { get; set; }
        public string TelefoneBiblioteca { get; set; }
        public string EmailBiblioteca { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Exemplar> Exemplares { get; set; }
    }
}