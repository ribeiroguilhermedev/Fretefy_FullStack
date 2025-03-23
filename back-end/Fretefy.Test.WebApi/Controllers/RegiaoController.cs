using Fretefy.Test.Domain.DTOs;
using Fretefy.Test.Domain.DTOs.Regiao;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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
        public IActionResult List()
        {
            var regioes = _regiaoService.List();
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
        public IActionResult PostNested([FromBody] RegiaoNestedDto regiaoNestedDto)
        {
            var regiao = _regiaoService.Add(regiaoNestedDto);
            var result = RegiaoOutputDto.FromEntity(regiao);
            
            return CreatedAtAction(nameof(Get), new { id = regiao.Id }, result);
        }
    }
} 