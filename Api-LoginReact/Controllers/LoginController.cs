using Api_LoginReact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_LoginReact.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Auth([FromBody] LoginRequest request)
        {
            if (request.email == "teste@saocritovao.com.br" && request.password == "123")
            {
                var token = TokenService.GenerateToken(request.email, request.password);
                return Ok(new { token });
            }
            return BadRequest(new { error = "Usuário ou senha inválida" });
        }
    }
}
