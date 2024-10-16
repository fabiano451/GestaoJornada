using Jornada.Entities.Entity;
using Jornada.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.Repository.Context
{
    public class JornadaContext : DbContext
    {
        public JornadaContext(DbContextOptions<JornadaContext> options) : base(options) { }
        public JornadaContext() { }

        public virtual DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
        }

    }
}
