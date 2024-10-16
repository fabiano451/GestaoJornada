using Jornada.Entities.DTO;
using Jornada.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.contracts.IService
{
    public interface IAlunoService
    {
        Task<IEnumerable<AlunoDTO>> GetAllAlunos();
        Task<AlunoDTO> GetAlunoById(int id);
        Task CreateAluno(AlunoDTO aluno);
        Task UpdateAluno(AlunoDTO aluno);
        Task DeleteAluno(int id);
    }
}
