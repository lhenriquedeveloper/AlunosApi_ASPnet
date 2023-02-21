using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;


//Contexto do Banco de dados + Config do Entity para realizar as migrações

namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Setando referencia as entidades
        public DbSet<Aluno> Alunos { get; set; }

        //Populando banco de dados na criação dos dados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno { 
                AlunoId=1,
                Nome= "Luis Henrique",
                Email = "luishenrique@teste.com.br",
                Idade = 23,
                },
                new Aluno { 
                AlunoId=2,
                Nome="Joãozin da Silva",
                Email = "joãozin@teste.com.br",
                Idade=23,
                }
                );
        }
    }
}
