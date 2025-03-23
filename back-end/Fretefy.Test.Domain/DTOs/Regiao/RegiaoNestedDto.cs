using System.Collections.Generic;
using Fretefy.Test.Domain.DTOs.Cidade;

namespace Fretefy.Test.Domain.DTOs.Regiao
{
    public class RegiaoNestedDto
    {
        public RegiaoNestedDto()
        {
            Cidades = new List<CidadeDto>();
        }
        
        public RegiaoDto Regiao { get; set; }
        public List<CidadeDto> Cidades { get; set; }
    }
} 