using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Editora:Entity<int>
    {
        public string NomeEditora { get; set; }
        public string Cidade { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}