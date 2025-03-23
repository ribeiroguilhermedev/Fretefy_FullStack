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
    }
} 