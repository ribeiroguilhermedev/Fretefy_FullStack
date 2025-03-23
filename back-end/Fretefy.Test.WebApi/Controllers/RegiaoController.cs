using System;
using System.Linq;
using Fretefy.Test.Domain.DTOs.Regiao;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Domain.Validators;
using Microsoft.AspNetCore.Mvc;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult List([FromQuery] bool? ativo = null)
        {
            var regioes = _regiaoService.List();
            
            if (ativo.HasValue)
                regioes = regioes.Where(r => r.Ativo == ativo!.Value);
                
            var result = regioes
                .Select(RegiaoOutputDto.FromEntity)
                .OrderByDescending(r => r.CriadoEm)
                .ToList();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var regiao = _regiaoService.Get(id);

            if (regiao == null)
                return NotFound();

            var result = RegiaoOutputDto.FromEntity(regiao);
            return Ok(result);
        }

        [HttpPost("nested")]
        public IActionResult PostAninhado([FromBody] RegiaoNestedDto regiaoNestedDto)
        {
            var validation = regiaoNestedDto.ValidarRequest();

            if (!validation.IsValid)
                return BadRequest(validation.ErrorMessage);

            var regiao = _regiaoService.Add(regiaoNestedDto);
            var result = RegiaoOutputDto.FromEntity(regiao);

            return CreatedAtAction(nameof(Get), new { id = regiao.Id }, result);
        }

        [HttpPost("{id}/cidades")]
        public IActionResult AdicionarCidades(Guid id, [FromBody] AdicionarCidadesRegiaoDto cidadesDto)
        {
            var validation = cidadesDto.ValidarRequest();

            if (!validation.IsValid)
                return BadRequest(validation.ErrorMessage);
            
            var regiao = _regiaoService.AdicionarCidades(id, cidadesDto);
            
            if (regiao == null)
                return NotFound();

            var result = RegiaoOutputDto.FromEntity(regiao);

            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var result = _regiaoService.Delete(id);
            
            if (!result)
                return NotFound();
                
            return NoContent();
        }
        
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] AtualizarRegiaoDto regiaoDto)
        {
            var validation = regiaoDto.ValidarRequest();

            if (!validation.IsValid)
                return BadRequest(validation.ErrorMessage);
            
            var regiao = _regiaoService.Update(id, regiaoDto);
            
            if (regiao == null)
                return NotFound();
                
            var result = RegiaoOutputDto.FromEntity(regiao);
            
            return Ok(result);
        }
        
        [HttpDelete("{regiaoId}/cidades/{cidadeId}")]
        public IActionResult RemoverCidade(Guid regiaoId, Guid cidadeId)
        {
            var result = _regiaoService.RemoverCidade(regiaoId, cidadeId);
            
            if (!result)
                return NotFound();
                
            return NoContent();
        }
        
        [HttpPatch("{id}/toggle-ativo")]
        public IActionResult ToggleAtivo(Guid id, [FromBody] ToggleAtivoRegiaoDto toggleDto = null)
        {
            var regiao = _regiaoService.ToggleAtivo(id, toggleDto);
            
            if (regiao == null)
                return NotFound();
                
            var result = RegiaoOutputDto.FromEntity(regiao);
            
            return Ok(result);
        }
    }
}