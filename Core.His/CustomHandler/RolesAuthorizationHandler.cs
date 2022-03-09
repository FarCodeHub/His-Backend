using DataAccess.Repositories.His;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.His.CustomHandler
{
    public class RolesAuthorizationHandler : AuthorizationHandler<RolesAuthorizationRequirement>, IAuthorizationHandler
    {

        private IUserRepository userRepository;
        private IRoleRepository roleRepository;
        private IUserRoleRepository userRoleRepository;

        public RolesAuthorizationHandler(IUserRepository userRepository, IRoleRepository roleRepository, IUserRoleRepository userRoleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.userRoleRepository = userRoleRepository;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       RolesAuthorizationRequirement requirement)
        {
            if (context.User == null || !context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            var validRole = false;
            if (requirement.AllowedRoles == null ||
                requirement.AllowedRoles.Any() == false)
            {
                validRole = true;
            }
            else
            {
                var claims = context.User.Claims;
                var userName = claims.FirstOrDefault(c => c.Type == "UserName").Value;
                var roles = requirement.AllowedRoles;

                validRole = (from u in userRepository.GetAll()
                             join ur in userRoleRepository.GetAll() on u.Id equals ur.UserId
                             join r in roleRepository.GetAll() on ur.RoleId equals r.Id
                             where roles.Contains(r.RoleTitle) && u.UserName == userName
                             select u).Any();

              //  validRole = roleRepository.GetAll().Where(p => roles.Contains(p.RoleName) && p.UserName == userName).Any();
            }

            if (validRole)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
