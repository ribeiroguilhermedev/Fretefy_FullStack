using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
            RegioesCidades = new List<RegiaoCidade>();
        }

        public Regiao(string nome, string descricao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            RegioesCidades = new List<RegiaoCidade>();
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<RegiaoCidade> RegioesCidades { get; set; }
    }
} 