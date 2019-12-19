using FourAsset.Domain.Models;
using FourAsset.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FourAsset.Infra.Data.Context
{
    public class FourAssetContext : DbContext
    {
        public virtual DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaConfiguration());
            modelBuilder.Entity<Tarefa>().HasData(
                new Tarefa { TarefaId = 1, Titulo = "Tarefa 1", Descricao = "Tarefa de teste 1", Status = false, DataDeCriacao = DateTime.Now, DataDeEdicao = DateTime.Now.AddMinutes(20), DataDeConclusao = DateTime.Now.AddMinutes(15), DataDeRemocao = DateTime.Now.AddMinutes(25) },
                new Tarefa { TarefaId = 2, Titulo = "Tarefa 2", Descricao = "Tarefa de teste 2", Status = false, DataDeCriacao = DateTime.Now, DataDeEdicao = DateTime.Now.AddMinutes(25), DataDeConclusao = DateTime.Now.AddMinutes(20), DataDeRemocao = DateTime.Now.AddMinutes(30) },
                new Tarefa { TarefaId = 3, Titulo = "Tarefa 2", Descricao = "Tarefa de teste 3", Status = false, DataDeCriacao = DateTime.Now, DataDeEdicao = DateTime.Now.AddMinutes(30), DataDeConclusao = DateTime.Now.AddMinutes(25), DataDeRemocao = DateTime.Now.AddMinutes(35) },
                new Tarefa { TarefaId = 4, Titulo = "Tarefa 4", Descricao = "Tarefa de teste 4", Status = false, DataDeCriacao = DateTime.Now, DataDeEdicao = DateTime.Now.AddMinutes(35), DataDeConclusao = DateTime.Now.AddMinutes(30), DataDeRemocao = DateTime.Now.AddMinutes(40) },
                new Tarefa { TarefaId = 5, Titulo = "Tarefa 5", Descricao = "Tarefa de teste 5", Status = false, DataDeCriacao = DateTime.Now, DataDeEdicao = DateTime.Now.AddMinutes(40), DataDeConclusao = DateTime.Now.AddMinutes(35), DataDeRemocao = DateTime.Now.AddMinutes(45) }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitProjects\4Asset\4Asset.Infra.Data\Data\FourAssetDatabase.mdf;Integrated Security=True");
        }

        public override int SaveChanges()
        {
            try
            {
                const string DATACRIACAO = "DataDeCriacao";
                const string DATAEDICAO = "DataDeEdicao";
                const string DATAREMOCAO = "DataDeRemocao";
                const string DATACONCLUSAO = "DataDeConclusao";
                const string STATUS = "Status";

                foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(DATACRIACAO) != null))
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property(DATACRIACAO).CurrentValue = DateTime.Now;
                    }
                    if (entry.State == EntityState.Modified)
                    {
                        entry.Property(DATAEDICAO).CurrentValue = DateTime.Now;
                    }
                    if (entry.State == EntityState.Deleted)
                    {
                        entry.Property(DATAREMOCAO).CurrentValue = DateTime.Now;
                    }
                    if ((bool)entry.Property(STATUS).CurrentValue)
                    {
                        entry.Property(DATACONCLUSAO).CurrentValue = DateTime.Now;
                    }
                }

                return base.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
