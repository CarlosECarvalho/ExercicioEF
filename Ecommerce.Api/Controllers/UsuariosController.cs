using Ecommerce.Api.Repositories;
using Ecommerce.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        //faço a injeção de dependência para chamar a interface ao iniciar o controller
        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var listaUsuarios = _usuarioRepository.Get();
            return Ok(listaUsuarios);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            if(usuario == null)
            {
                return NotFound("Não encontrado!");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Usuario usuario) //recebo o usuário da própria requsição através do FromBody
        {
            //aqui devem ser tratadas as validações do usuário antes de inserir
            _usuarioRepository.Add(usuario);
            return Ok(usuario);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Usuario usuario, int id)
        {//aqui devem ser tratadas as validações de usuário e id antes de atualizar
            _usuarioRepository.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {// deve tratar de validações se o objeto existe no banco
            _usuarioRepository.Delete(id);
            return Ok(true);
        }
    }
}
