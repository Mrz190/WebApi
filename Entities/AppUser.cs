﻿using Microsoft.AspNetCore.Identity;

namespace WebApiCourse6_7.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string NickName { get; set; } = null!;
        public DateTime WasCreated { get; set; } = DateTime.Now;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
