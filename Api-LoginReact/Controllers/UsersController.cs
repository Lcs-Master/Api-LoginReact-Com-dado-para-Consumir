using Api_LoginReact.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_LoginReact.Controllers
{
    
    [Route("api/user")]
    public class UsersController : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetUsers()
        {
           
            var usuarios = Usuarios.ObterUsuarios();

            return Ok(usuarios);
        }
    }
}
