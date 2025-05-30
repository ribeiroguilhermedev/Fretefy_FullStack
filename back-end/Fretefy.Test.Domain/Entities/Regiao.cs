using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public sealed class Regiao : IEntity
    {
        public Regiao()
        {
            RegioesCidades = new List<RegiaoCidade>();
            CriadoEm = DateTime.Now;
            AtualizadoEm = DateTime.Now;
            Ativo = true;
        }

        public Regiao(string nome, string descricao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            RegioesCidades = new List<RegiaoCidade>();
            CriadoEm = DateTime.Now;
            AtualizadoEm = DateTime.Now;
            Ativo = true;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }
        
        public bool Ativo { get; set; }

        public ICollection<RegiaoCidade> RegioesCidades { get; set; }
    }
} 