using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.Handlers
{
    [Authorize(Policy = "AdminOnly")]

    public class AdminEmailHandler : AuthorizationHandler<RequireAdminRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RequireAdminRequirement requirement)
        {
            if (!context.User.HasClaim(e => e.Type == ClaimTypes.Email))
            {
                return Task.CompletedTask;
            }
            string userEmail = context.User.FindFirst(claim => claim.Type == ClaimTypes.Email).Value;
            if (userEmail.Contains("admin@thewrightstuff.com"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
