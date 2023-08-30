using DevTestApi.Domain;
using DevTestApi.Domain.Commands.Requests;
using DevTestApi.Dto;
using DevTestApi.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevTestApi.Controllers
{
    public class CadTesteController : ControllerBase
    {
        //private readonly ICadTesteRepository _cadTesteRepository;
        //public CadTesteController(ICadTesteRepository cadTesteRepository)
        //{
        //    _cadTesteRepository = cadTesteRepository;
        //}

        //[HttpGet]
        //[Route(template: "")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var retorno = await _cadTesteRepository.GetAll();
        //    return retorno?.Count > 0 ? Ok(retorno) : BadRequest();
        //}

        [HttpPost(template: "cad")]
        public IActionResult Post([FromServices] IMediator mediator,
            [FromBody] CreateCadTesteRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }

        //[HttpPut(template: "cad/{id}")]
        //public async Task<IActionResult> Update(int id, CadTesteRequest cadTesteRequest)
        //{
        //    CadTeste cadTeste = new CadTeste()
        //    {
        //        Id = id,
        //        Nome = cadTesteRequest.Nome,
        //        Email = cadTesteRequest.Email,
        //        Cidade = cadTesteRequest.Cidade
        //    };

        //    var retorno = await _cadTesteRepository.Update(cadTeste);

        //    if (retorno)
        //    {
        //        return Ok();
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}

        //[HttpDelete(template: "cad/{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var retorno = await _cadTesteRepository.Delete(id);

        //    if (retorno)
        //    {
        //        return Ok();
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
