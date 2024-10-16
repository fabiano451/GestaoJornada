using Jornada.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.contracts.IRepository
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> GetAll();
        Task<Aluno> GetById(int id);
        Task Add(Aluno aluno);
        Task Update(Aluno aluno);
        Task Delete(int id);
    }
}
