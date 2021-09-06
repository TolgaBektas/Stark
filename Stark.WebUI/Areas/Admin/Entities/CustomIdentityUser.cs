using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Areas.Admin.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        public bool Confirmed { get; set; }
    }
}
