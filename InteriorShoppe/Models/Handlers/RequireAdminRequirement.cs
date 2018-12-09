using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.Handlers
{
    public class RequireAdminRequirement : IAuthorizationRequirement
    {
        public RequireAdminRequirement()
        {

        }
    }
}
