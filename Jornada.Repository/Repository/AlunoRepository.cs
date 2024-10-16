using Jornada.contracts.IRepository;
using Jornada.Entities.Entity;
using Jornada.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.Repository.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>,  IAlunoRepository
    {
        public AlunoRepository(JornadaContext context) : base(context) { }

        public async Task<IEnumerable<Aluno>> GetAll()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task<Aluno> GetById(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task Add(Aluno aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
                await _context.SaveChangesAsync();
            }
        }
    }
}
