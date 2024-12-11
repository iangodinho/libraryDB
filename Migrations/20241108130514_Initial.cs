using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAutor = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorID);
                });

            migrationBuilder.CreateTable(
                name: "Editoras",
                columns: table => new
                {
                    EditoraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEditora = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoras", x => x.EditoraID);
                });

            migrationBuilder.CreateTable(
                name: "EstadosBrasileiros",
                columns: table => new
                {
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosBrasileiros", x => x.UF);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GeneroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeGenero = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroID);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLivro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QntdPaginas = table.Column<int>(type: "int", nullable: false),
                    EditoraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Livros_Editoras_EditoraID",
                        column: x => x.EditoraID,
                        principalTable: "Editoras",
                        principalColumn: "EditoraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoID);
                    table.ForeignKey(
                        name: "FK_Enderecos_EstadosBrasileiros_UF",
                        column: x => x.UF,
                        principalTable: "EstadosBrasileiros",
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLivros",
                columns: table => new
                {
                    AutorLivroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLivros", x => x.AutorLivroID);
                    table.ForeignKey(
                        name: "FK_AutorLivros_Autores_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autores",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLivros_Livros_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivroGeneros",
                columns: table => new
                {
                    LivroGeneroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneroID = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroGeneros", x => x.LivroGeneroID);
                    table.ForeignKey(
                        name: "FK_LivroGeneros_Generos_GeneroID",
                        column: x => x.GeneroID,
                        principalTable: "Generos",
                        principalColumn: "GeneroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivroGeneros_Livros_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotecas",
                columns: table => new
                {
                    BibliotecaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeBiblioteca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelefoneBiblioteca = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmailBiblioteca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecas", x => x.BibliotecaID);
                    table.ForeignKey(
                        name: "FK_Bibliotecas_Enderecos_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    CPFUsuario = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DataNascimentoUsuario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelefoneUsuario = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EnderecoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.CPFUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Enderecos_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exemplares",
                columns: table => new
                {
                    ExemplarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BibliotecaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemplares", x => x.ExemplarID);
                    table.ForeignKey(
                        name: "FK_Exemplares_Bibliotecas_BibliotecaID",
                        column: x => x.BibliotecaID,
                        principalTable: "Bibliotecas",
                        principalColumn: "BibliotecaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exemplares_Livros_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    EmprestimoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExemplarID = table.Column<int>(type: "int", nullable: false),
                    CPFUsuario = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusEmprestimo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.EmprestimoID);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Exemplares_ExemplarID",
                        column: x => x.ExemplarID,
                        principalTable: "Exemplares",
                        principalColumn: "ExemplarID");
                    table.ForeignKey(
                        name: "FK_Emprestimos_Usuarios_CPFUsuario",
                        column: x => x.CPFUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "CPFUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Devolucoes",
                columns: table => new
                {
                    DevolucaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExemplarID = table.Column<int>(type: "int", nullable: false),
                    CPFUsuario = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmprestimoID = table.Column<int>(type: "int", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucoes", x => x.DevolucaoID);
                    table.ForeignKey(
                        name: "FK_Devolucoes_Emprestimos_EmprestimoID",
                        column: x => x.EmprestimoID,
                        principalTable: "Emprestimos",
                        principalColumn: "EmprestimoID");
                    table.ForeignKey(
                        name: "FK_Devolucoes_Exemplares_ExemplarID",
                        column: x => x.ExemplarID,
                        principalTable: "Exemplares",
                        principalColumn: "ExemplarID");
                    table.ForeignKey(
                        name: "FK_Devolucoes_Usuarios_CPFUsuario",
                        column: x => x.CPFUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "CPFUsuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivros_AutorID",
                table: "AutorLivros",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivros_ISBN",
                table: "AutorLivros",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotecas_EnderecoID",
                table: "Bibliotecas",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_CPFUsuario",
                table: "Devolucoes",
                column: "CPFUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_EmprestimoID",
                table: "Devolucoes",
                column: "EmprestimoID");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_ExemplarID",
                table: "Devolucoes",
                column: "ExemplarID");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_CPFUsuario",
                table: "Emprestimos",
                column: "CPFUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_ExemplarID",
                table: "Emprestimos",
                column: "ExemplarID");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_UF",
                table: "Enderecos",
                column: "UF");

            migrationBuilder.CreateIndex(
                name: "IX_Exemplares_BibliotecaID",
                table: "Exemplares",
                column: "BibliotecaID");

            migrationBuilder.CreateIndex(
                name: "IX_Exemplares_ISBN",
                table: "Exemplares",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_LivroGeneros_GeneroID",
                table: "LivroGeneros",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_LivroGeneros_ISBN",
                table: "LivroGeneros",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EditoraID",
                table: "Livros",
                column: "EditoraID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EnderecoID",
                table: "Usuarios",
                column: "EnderecoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLivros");

            migrationBuilder.DropTable(
                name: "Devolucoes");

            migrationBuilder.DropTable(
                name: "LivroGeneros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Exemplares");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Bibliotecas");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Editoras");

            migrationBuilder.DropTable(
                name: "EstadosBrasileiros");
        }
    }
}
