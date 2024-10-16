using AutoMapper;
using System.Globalization;

namespace Jornada.AutoMapper
{
    public class EntityToDTOMaper : Profile
    {
        public EntityToDTOMaper()
        {
            var culture = new CultureInfo("pt-BR");
            culture.NumberFormat.NumberDecimalSeparator = ",";

            CreateMap<Aluno,AlunoDTO>();

        }
    }
}
