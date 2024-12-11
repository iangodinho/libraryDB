using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryManagement.Configurations;
using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        //public DbSet<LivroGenero> LivroGeneros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        //public DbSet<AutorLivro> AutorLivros { get; set; }
        public DbSet<EstadosBrasileiros> EstadosBrasileiros { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Biblioteca> Bibliotecas { get; set; }
        public DbSet<Exemplar> Exemplares { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EditoraConfigurations());
            modelBuilder.ApplyConfiguration(new GeneroConfigurations());
            modelBuilder.ApplyConfiguration(new LivroConfigurations());
            //modelBuilder.ApplyConfiguration(new LivroGeneroConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfigurations());
            //modelBuilder.ApplyConfiguration(new AutorLivroConfigurations());
            modelBuilder.ApplyConfiguration(new EstadosBrasileirosConfigurations());
            modelBuilder.ApplyConfiguration(new EnderecosConfigurations());
            modelBuilder.ApplyConfiguration(new UsuarioConfigurations());
            modelBuilder.ApplyConfiguration(new BibliotecaConfigurations());
            modelBuilder.ApplyConfiguration(new ExemplarConfigurations());
            modelBuilder.ApplyConfiguration(new EmprestimoConfigurations());
            modelBuilder.ApplyConfiguration(new DevolucaoConfigurations());
        }
    }
}