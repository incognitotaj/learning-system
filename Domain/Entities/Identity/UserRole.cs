﻿using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class UserRole : IdentityUserRole<string>
    {
        public virtual AppUser User { get; set; }
        public virtual AppRole Role { get; set; }
    }
}
