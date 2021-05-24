﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UntoldApp.Models;

namespace UntoldApp.Models
{
    public class AuthenticationContext :IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<UntoldApp.Models.ApplicationUserModel> ApplicationUserModel { get; set; }
    }
}
