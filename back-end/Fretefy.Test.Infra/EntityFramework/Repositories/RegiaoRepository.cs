using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly TestDbContext _context;

        public RegiaoRepository(TestDbContext context)
        {
            _context = context;
        }

        public IQueryable<Regiao> List()
        {
            return _context.Regioes
                .Include(r => r.RegioesCidades)
                .ThenInclude(rc => rc.Cidade);
        }

        public Regiao GetById(Guid id)
        {
            return _context.Regioes
                .Include(r => r.RegioesCidades)
                .ThenInclude(rc => rc.Cidade)
                .FirstOrDefault(r => r.Id == id);
        }

        public Regiao Add(Regiao regiao)
        {
            _context.Regioes.Add(regiao);
            _context.SaveChanges();
            return regiao;
        }
        
        public void AddRegiaoCidade(RegiaoCidade regiaoCidade)
        {
            _context.RegioesCidades.Add(regiaoCidade);
            _context.SaveChanges();
        }

        public bool Delete(Guid id)
        {
            var regiao = _context.Regioes.Find(id);
            if (regiao == null)
                return false;

            _context.Regioes.Remove(regiao);
            _context.SaveChanges();
            
            return true;
        }
        
        public Regiao Update(Regiao regiao)
        {
            var existingRegiao = _context.Regioes.Find(regiao.Id);
            if (existingRegiao == null)
                return null;
                
            existingRegiao.Nome = regiao.Nome;
            existingRegiao.Descricao = regiao.Descricao;
            existingRegiao.AtualizadoEm = DateTime.Now;
            
            _context.SaveChanges();
            return existingRegiao;
        }
        
        public bool RemoverRegiaoCidade(Guid regiaoId, Guid cidadeId)
        {
            var regiaoCidade = _context.RegioesCidades
                .FirstOrDefault(rc => rc.RegiaoId == regiaoId && rc.CidadeId == cidadeId);
                
            if (regiaoCidade == null)
                return false;
                
            _context.RegioesCidades.Remove(regiaoCidade);
            _context.SaveChanges();
            
            return true;
        }
    }
} 