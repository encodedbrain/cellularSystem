using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using cellularSystem.Models;
using Microsoft.IdentityModel.Tokens;

namespace lodging.Services
{
    public class TokenServices
    {
        public  object GenerateToken(CellphoneModel cell)
        {
            var builder = WebApplication.CreateBuilder();

            string? hash = builder.Configuration.GetConnectionString("secret");

            if (hash != null)
            {
                var key = Encoding.ASCII.GetBytes(hash);

                if (cell != null)
                {
                    SecurityTokenDescriptor config = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(
                            new[]
                            {
                                new Claim(ClaimTypes.Name, cell.Model),
                                new Claim(
                                    ClaimTypes.Role,
                                    cell.Brand ?? throw new InvalidOperationException()
                                )
                            }
                        ),
                        Expires = DateTime.UtcNow.AddHours(2),
                        SigningCredentials = new SigningCredentials(
                            new SymmetricSecurityKey(key),
                            SecurityAlgorithms.HmacSha256Signature
                        ),
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var tokenCreate = tokenHandler.CreateToken(config);
                    var token = tokenHandler.WriteToken(tokenCreate);

                    return new { token };
                }
            }

            return null!;
        }
    }
}
