﻿using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
