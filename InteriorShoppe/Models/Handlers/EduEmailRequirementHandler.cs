using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


    namespace InteriorShoppe.Models.Handlers
    {
        public class EduEmailRequirementHandler : AuthorizationHandler<EduEmailRequirementHandler>, IAuthorizationRequirement
        {
        /// <summary>
        /// Handler to verify that the email claim has been met
        /// </summary>
        /// <param name="context">Authorization Handler</param>
        /// <param name="requirement">Email Requirement</param>
        /// <returns>Task Completed</returns>
            protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EduEmailRequirementHandler requirement)
            {
                if (!context.User.HasClaim(e => e.Type == ClaimTypes.Email))
                {
                    return Task.CompletedTask;
                }

                var userEmail = context.User.FindFirst(email => email.Type == ClaimTypes.Email).Value;

                if (userEmail.Contains(".edu"))
                {
                    context.Succeed(requirement);
                }

                return Task.CompletedTask;
            }
        }
    }
