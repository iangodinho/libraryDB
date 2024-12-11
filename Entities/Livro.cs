using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace LibraryManagement.Entities
{
    public class Livro:Entity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ISBN { get; set; }

        [Required]
        [MaxLength(255)]
        public string NomeLivro { get; set; }

        [Required]
        public int QntdPaginas { get; set; }

        [ForeignKey("Editora")]
        public int EditoraID { get; set; }
        public Editora Editora { get; set; }

        public ICollection<AutorLivro> AutorLivros { get; set; }
        public ICollection<LivroGenero> LivroGeneros { get; set; }
        public ICollection<Exemplar> Exemplares { get; set; }
    }
}

