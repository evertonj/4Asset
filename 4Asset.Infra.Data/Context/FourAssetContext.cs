using _4Asset.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace _4Asset.Infra.Data.Context
{
    public class FourAssetContext : DbContext
    {
        public virtual DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().HasData(
                new Tarefa { TarefaId = 1,Titulo="Tarefa 1",Descricao="Tarefa de teste 1",Status=false,DataDeCriacao = DateTime.Now,DataDeEdicao = DateTime.Now.AddMinutes(20),DataDeConclusao=DateTime.Now.AddMinutes(15),DataDeRemocao=DateTime.Now.AddMinutes(25)},
                new Tarefa { TarefaId = 2,Titulo="Tarefa 2",Descricao="Tarefa de teste 2",Status=false,DataDeCriacao = DateTime.Now,DataDeEdicao = DateTime.Now.AddMinutes(25),DataDeConclusao=DateTime.Now.AddMinutes(20),DataDeRemocao=DateTime.Now.AddMinutes(30)},
                new Tarefa { TarefaId = 3,Titulo="Tarefa 2",Descricao="Tarefa de teste 3",Status=false,DataDeCriacao = DateTime.Now,DataDeEdicao = DateTime.Now.AddMinutes(30),DataDeConclusao=DateTime.Now.AddMinutes(25),DataDeRemocao=DateTime.Now.AddMinutes(35)},
                new Tarefa { TarefaId = 4,Titulo="Tarefa 4",Descricao="Tarefa de teste 4",Status=false,DataDeCriacao = DateTime.Now,DataDeEdicao = DateTime.Now.AddMinutes(35),DataDeConclusao=DateTime.Now.AddMinutes(30),DataDeRemocao=DateTime.Now.AddMinutes(40)},
                new Tarefa { TarefaId = 5,Titulo="Tarefa 5",Descricao="Tarefa de teste 5",Status=false,DataDeCriacao = DateTime.Now,DataDeEdicao = DateTime.Now.AddMinutes(40),DataDeConclusao=DateTime.Now.AddMinutes(35),DataDeRemocao=DateTime.Now.AddMinutes(45)}
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FourAssetDb;Integrated Security=True");
        }
    }
}
