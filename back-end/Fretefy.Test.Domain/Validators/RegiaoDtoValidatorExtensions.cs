using System;
using System.Linq;
using Fretefy.Test.Domain.DTOs.Regiao;

namespace Fretefy.Test.Domain.Validators
{
    public static class RegiaoDtoValidatorExtensions
    {
        public static ValiadacaoResult ValidarRequest(this RegiaoNestedDto dto)
        {
            if (dto == null)
                return new ValiadacaoResult(false, "Dados inválidos.");

            if (dto.Regiao == null)
                return new ValiadacaoResult(false, "Dados da região são obrigatórios.");
                
            if (string.IsNullOrWhiteSpace(dto.Regiao.Nome))
                return new ValiadacaoResult(false, "O nome da região é obrigatório.");
                
            if (dto.Regiao.Nome.Length > 100)
                return new ValiadacaoResult(false, "O nome da região não pode ter mais de 100 caracteres.");
                
            if (dto.Regiao.Descricao?.Length > 500)
                return new ValiadacaoResult(false, "A descrição da região não pode ter mais de 500 caracteres.");
                
            if (dto.Cidades == null)
                return new ValiadacaoResult(false, "A lista de cidades não pode ser nula.");
                
            foreach (var cidade in dto.Cidades)
            {
                if (cidade.Id == null || cidade.Id == Guid.Empty)
                    return new ValiadacaoResult(false, "Todas as cidades devem ter um ID válido.");
            }
            
            return new ValiadacaoResult(true);
        }
        
        public static ValiadacaoResult ValidarRequest(this AdicionarCidadesRegiaoDto dto)
        {
            if (dto == null)
                return new ValiadacaoResult(false, "Dados inválidos.");
                
            if (dto.CidadesIds == null || !dto.CidadesIds.Any())
                return new ValiadacaoResult(false, "É necessário informar pelo menos uma cidade.");
                
            foreach (var cidadeId in dto.CidadesIds)
            {
                if (cidadeId == Guid.Empty)
                    return new ValiadacaoResult(false, "Todos os IDs de cidade devem ser válidos.");
            }
            
            return new ValiadacaoResult(true);
        }
        
            public static ValiadacaoResult ValidarRequest(this AtualizarRegiaoDto dto)
        {
            if (dto == null)
                return new ValiadacaoResult(false, "Dados inválidos.");
                
            if (string.IsNullOrWhiteSpace(dto.Nome))
                return new ValiadacaoResult(false, "O nome da região é obrigatório.");
                
            if (dto.Nome.Length > 100)
                return new ValiadacaoResult(false, "O nome da região não pode ter mais de 100 caracteres.");
                
            if (dto.Descricao?.Length > 500)
                return new ValiadacaoResult(false, "A descrição da região não pode ter mais de 500 caracteres.");
            
            return new ValiadacaoResult(true);
        }
    }
    
    public class ValiadacaoResult
    {
        public bool IsValid { get; }
        public string ErrorMessage { get; }
        
        public ValiadacaoResult(bool isValid, string errorMessage = null)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }
    }
} 