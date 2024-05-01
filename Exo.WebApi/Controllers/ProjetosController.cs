using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exo.WebApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _repository;

        public ProjetoController(ProjetoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_repository.Listar());
        }
    }
}