using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        IQueryable<Regiao> List();
        Regiao GetById(Guid id);
        Regiao Add(Regiao regiao);
        void AddRegiaoCidade(RegiaoCidade regiaoCidade);
        bool Delete(Guid id);
        Regiao Update(Regiao regiao);
        bool RemoverRegiaoCidade(Guid regiaoId, Guid cidadeId);
    }
} 