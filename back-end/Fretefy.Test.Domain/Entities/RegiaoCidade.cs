using System;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade : IEntity
    {
        public RegiaoCidade()
        {
        }

        public RegiaoCidade(Guid regiaoId, Guid cidadeId)
        {
            Id = Guid.NewGuid();
            RegiaoId = regiaoId;
            CidadeId = cidadeId;
        }

        public Guid Id { get; set; }

        public Guid RegiaoId { get; set; }
        public virtual Regiao Regiao { get; set; }

        public Guid CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
} 