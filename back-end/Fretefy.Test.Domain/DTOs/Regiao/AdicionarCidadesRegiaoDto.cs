using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.DTOs.Regiao
{
    public class AdicionarCidadesRegiaoDto
    {
        public AdicionarCidadesRegiaoDto()
        {
            CidadesIds = new List<Guid>();
        }
        
        public List<Guid> CidadesIds { get; set; }
    }
} 