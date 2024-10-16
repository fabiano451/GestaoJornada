using Jornada.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.Repository.Mapping
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey(a => a.AlunoId).HasName("Pk_Aluno");
            builder.Property(a => a.AlunoId).HasColumnName("AlunoId").HasColumnType("int").IsRequired();
            builder.Property(a => a.Nome).HasColumnName("Nome").HasColumnType("nvarchar(100").IsRequired();
            builder.Property(a => a.CPF).HasColumnName("CPF").HasColumnType("varchar(11)").IsRequired();
            builder.Property(a => a.Email).HasColumnName("Email").HasColumnType("nvarchar(100").IsRequired();
            builder.Property(a => a.Telefone).HasColumnName("Telefone").HasColumnType("nvarchar(15").IsRequired();
            builder.Property(a => a.Endereco).HasColumnName("Endereco").HasColumnType("nvarchar(200").IsRequired();
            builder.Property(a => a.DataCadastro).HasColumnName("DataCadastro").HasColumnType("DATETIME").IsRequired();
        }
    }
}
