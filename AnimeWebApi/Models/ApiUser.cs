﻿using Microsoft.AspNetCore.Identity;

namespace AnimeWebApi.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
