using Fretefy.Test.Domain.DTOs;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Fretefy.Test.Domain.DTOs.Regiao;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public IEnumerable<Regiao> List()
        {
            return _regiaoRepository.List().ToList();
        }

        public Regiao Get(Guid id)
        {
            return _regiaoRepository.GetById(id);
        }

        public Regiao Add(RegiaoNestedDto regiaoNestedDto)
        {
            var regiao = new Regiao(regiaoNestedDto.Regiao.Nome, regiaoNestedDto.Regiao.Descricao);
            regiao = _regiaoRepository.Add(regiao);

            regiaoNestedDto.Cidades
                .Where(c => c.Id.HasValue)
                .Select(c => c.Id.Value)
                .ToList()
                .ForEach(c =>
                    {
                        var regiaoCidade = new RegiaoCidade(regiao.Id, c);
                        _regiaoRepository.AddRegiaoCidade(regiaoCidade);
                    }
                );

            return _regiaoRepository.GetById(regiao.Id);
        }

        public Regiao AdicionarCidades(Guid regiaoId, AdicionarCidadesRegiaoDto cidadesDto)
        {
            var regiao = _regiaoRepository.GetById(regiaoId);
            if (regiao == null)
                return null;

            if (cidadesDto.CidadesIds == null || !cidadesDto.CidadesIds.Any())
                return _regiaoRepository.GetById(regiaoId);
            
            var cidadesExistentes = regiao.RegioesCidades.Select(rc => rc.CidadeId).ToList();
                
            var novasCidades = cidadesDto.CidadesIds.Where(id => !cidadesExistentes.Contains(id)).ToList();
                
            var regiaoCidades = novasCidades.Select(cidadeId => new RegiaoCidade(regiaoId, cidadeId)).ToList();
            foreach (var regiaoCidade in regiaoCidades)
                _regiaoRepository.AddRegiaoCidade(regiaoCidade);

            return _regiaoRepository.GetById(regiaoId);
        }
        
        public bool Delete(Guid id)
        {
            return _regiaoRepository.Delete(id);
        }
        
        public Regiao Update(Guid id, AtualizarRegiaoDto regiaoDto)
        {
            var regiao = _regiaoRepository.GetById(id);
            if (regiao == null)
                return null;
                
            regiao.Nome = regiaoDto.Nome;
            regiao.Descricao = regiaoDto.Descricao;
            
            return _regiaoRepository.Update(regiao);
        }
        
        public bool RemoverCidade(Guid regiaoId, Guid cidadeId)
        {
            return _regiaoRepository.RemoverRegiaoCidade(regiaoId, cidadeId);
        }
    }
}