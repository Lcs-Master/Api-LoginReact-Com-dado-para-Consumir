using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Api_LoginReact.Models
{
    public class TokenService
    {
        public static object GenerateToken(string email, string password)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret); 

            // Configuração do token
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, email) 
                }),
                Expires = DateTime.UtcNow.AddYears(300), 
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            // Gerar o token
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            // Retornar o token como um objeto anônimo
            return new
            {
                token = tokenString
            };
        }
    }
}
