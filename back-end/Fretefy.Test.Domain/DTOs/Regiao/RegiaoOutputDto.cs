using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.DTOs.Regiao
{
    public class RegiaoOutputDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public bool Ativo { get; set; }
        public List<CidadeOutputDto> Cidades { get; set; } = new List<CidadeOutputDto>();

        public static RegiaoOutputDto FromEntity(Entities.Regiao regiao)
        {
            if (regiao == null)
                return null;

            return new RegiaoOutputDto
            {
                Id = regiao.Id,
                Nome = regiao.Nome,
                Descricao = regiao.Descricao,
                CriadoEm = regiao.CriadoEm,
                AtualizadoEm = regiao.AtualizadoEm,
                Ativo = regiao.Ativo,
                Cidades = regiao.RegioesCidades?
                    .Where(rc => rc.Cidade != null)
                    .Select(rc => new CidadeOutputDto
                    {
                        Id = rc.Cidade.Id,
                        Nome = rc.Cidade.Nome,
                        UF = rc.Cidade.UF
                    })
                    .ToList() ?? new List<CidadeOutputDto>()
            };
        }
    }

    public class CidadeOutputDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
} 