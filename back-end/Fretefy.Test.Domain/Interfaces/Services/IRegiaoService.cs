using Fretefy.Test.Domain.DTOs;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using Fretefy.Test.Domain.DTOs.Regiao;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        IEnumerable<Regiao> List();
        Regiao Get(Guid id);
        Regiao Add(RegiaoNestedDto regiaoNestedDto);
        Regiao AdicionarCidades(Guid regiaoId, AdicionarCidadesRegiaoDto cidadesDto);
        bool Delete(Guid id);
        Regiao Update(Guid id, AtualizarRegiaoDto regiaoDto);
        bool RemoverCidade(Guid regiaoId, Guid cidadeId);
    }
} 