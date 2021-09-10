using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using OrchestratorService;
using RequestHandlerService;
using AuthenticationServiceProto;
using Common;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.ObjectModel;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace OrchestrationServer.Services
{
    public class AuthenticatorService : AuthenticatorServiceRpc.AuthenticatorServiceRpcBase
    {
        private readonly JwtSecurityTokenHandler m_jwtTokenHandler = new JwtSecurityTokenHandler();
        private readonly SymmetricSecurityKey m_securityKey = new SymmetricSecurityKey(Guid.NewGuid().ToByteArray());
        public AuthenticatorService() { }

        public override Task<AuthReply> ReturnToken(AuthRequest request, ServerCallContext context)
        {
            return Task.FromResult(GenerateJwtToken(request.Username, m_jwtTokenHandler, m_securityKey)); ;
        }

        private static AuthReply GenerateJwtToken(string p_username, JwtSecurityTokenHandler p_jwtTokenHandler, SymmetricSecurityKey p_securityKey)
        {
            var reply = new AuthReply();
            
            
            if (string.IsNullOrEmpty(p_username))
            {
                throw new InvalidOperationException("Username is not specified.");
            }

            Collection<UserRepo.ClientUser> users = Common.UserRepo.Users();

            var user = users.Where(o => o.UserName == p_username.ToLower()).FirstOrDefault();

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, p_username));
            foreach (var role in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.ToString()));
                reply.Roles.Add(new AuthRole()
                {
                    Name = role.ToString()
                });
            }

            var credentials = new SigningCredentials(p_securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                "ExampleServer",
                "ExampleClients",
                claims.ToArray(),
                expires: DateTime.Now.AddSeconds(60),
                signingCredentials: credentials);
            
            reply.Token = p_jwtTokenHandler.WriteToken(token);
            

            return reply;
        }

    }
}
