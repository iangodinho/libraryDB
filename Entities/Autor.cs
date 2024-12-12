using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Autor:Entity<int>
    {
        public string NomeAutor { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}