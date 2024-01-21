using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EYouthUnisco.API.Controllers.Handler
{
    public class JWTHandler
    {
        private readonly IConfiguration _configuration;

        public JWTHandler(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public async Task<JwtSecurityToken> GenerateToken(string username, string role)
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,username),
                    new Claim("role", role),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var token = new JwtSecurityToken(
                    issuer: _configuration["JwtSettings:ValidIssuer"],
                    audience: _configuration["JwtSettings:ValidAudience"],
                    expires: DateTime.Now.AddMonths(1),
                    claims: authClaims,
                    signingCredentials: credentials
                    );
                return token;
            }
            catch
            {
                return null;
            }
        }

    }
}
