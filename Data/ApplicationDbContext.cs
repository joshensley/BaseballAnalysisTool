using BaseballAnalysisTool.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BaseballAnalysisTool.Areas.Admin.Models;

namespace BaseballAnalysisTool.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<StateOrProvince> StateOrProvinces { get; set; }
        public DbSet<BaseballLeague> BaseballLeagues { get; set; }
        public DbSet<BaseballDivision> BaseballDivisions { get; set; }
        public DbSet<BaseballTeam> BaseballTeam { get; set; }

    }
}
