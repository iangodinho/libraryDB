using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Humanizer.Localisation;
using System.Numerics;


namespace LibraryManagement.Entities
{
    public class Livro:Entity<int>
    {
        public int ISBN { get; set; }
        public string NomeLivro { get; set; }
        public int QntdPaginas { get; set; }

        public int EditoraId { get; set; }
        public Editora Editora { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }

        public ICollection<Genero> Generos { get; set; }
        public ICollection<Exemplar> Exemplares { get; set; }

        public Livro()
        {
            Generos = new List<Genero>();
        }
    }
}

