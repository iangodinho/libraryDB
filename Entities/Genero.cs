using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Genero:Entity<int>
    {
        public string NomeGenero { get; set; }
        public ICollection<Livro> Livros { get; set; }

        public Genero()
        {
            Livros = new List<Livro>();
        }
    }
}