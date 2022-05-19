using chapterFS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chapterFS.Controllers
{
     [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class LivroController : ControllerBase
    {
        private LivroRepository _livroRepository;

        public LivroController( LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                 return Ok (_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
