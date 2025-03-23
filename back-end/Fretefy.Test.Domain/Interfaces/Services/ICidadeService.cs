using System;
using System.Collections.Generic;
using Fretefy.Test.Domain.Entities;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface ICidadeService
    {
        Cidade Get(Guid id);
        IEnumerable<Cidade> List();
        IEnumerable<Cidade> ListByUf(string uf);
        IEnumerable<Cidade> Query(string terms);
    }
}
