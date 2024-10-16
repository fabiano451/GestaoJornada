using AutoMapper;
using Jornada.contracts.IRepository;
using Jornada.contracts.IService;
using Jornada.Entities.DTO;
using Jornada.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada.Business
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private IMapper _mapper;

        public AlunoService(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AlunoDTO>> GetAllAlunos()
        {
            var result = await _alunoRepository.GetAll();
            return _mapper.Map<IEnumerable<AlunoDTO>>(result);
        }

        public async Task<AlunoDTO> GetAlunoById(int id)
        {
            var result = await _alunoRepository.GetById(id);
            return _mapper.Map<AlunoDTO>(result);
        }

        public async Task CreateAluno(AlunoDTO aluno)
        {
            // Aqui pode-se adicionar regras de negócio específicas
            var alunoEntity = new Aluno();
            await _alunoRepository.Add(alunoEntity);
        }

        public async Task UpdateAluno(AlunoDTO aluno)
        {
            var alunoEntity = new Aluno();
            await _alunoRepository.Update(alunoEntity);
        }

        public async Task DeleteAluno(int id)
        {
            await _alunoRepository.Delete(id);
        }
    }

}
