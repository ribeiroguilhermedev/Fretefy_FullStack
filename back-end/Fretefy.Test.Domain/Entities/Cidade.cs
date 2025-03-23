﻿using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Cidade : IEntity
    {
        public Cidade()
        {
            RegioesCidades = new List<RegiaoCidade>();
        }

        public Cidade(string nome, string uf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
            RegioesCidades = new List<RegiaoCidade>();
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string UF { get; set; }
        
        public virtual ICollection<RegiaoCidade> RegioesCidades { get; set; }
    }
}
