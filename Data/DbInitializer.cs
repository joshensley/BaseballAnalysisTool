using BaseballAnalysisTool.Areas.Admin.Models;
using BaseballAnalysisTool.Data.SeedData;
using BaseballAnalysisTool.Models;
using BaseballAnalysisTool.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(
            ApplicationDbContext db, 
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager) 
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            if (_db.Roles.Any(r => r.Name == SD.AdminEndUser)) return;

            _roleManager.CreateAsync(new IdentityRole(SD.AdminEndUser)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(SD.CustomerEndUser)).GetAwaiter().GetResult();


            ApplicationUser applicationUser = new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                FirstName = "Admin",
                LastName = "User",
                EmailConfirmed = true
            };

            _userManager.CreateAsync(applicationUser, "Admin123!").GetAwaiter().GetResult();

            ApplicationUser user = await _db.Users.FirstOrDefaultAsync(u => u.Email == "admin@gmail.com");

            _userManager.AddToRoleAsync(user, SD.AdminEndUser).GetAwaiter().GetResult();

            // Seed Countries in Database
            _db.Country.AddRange(CountrySeedData.GetData());
            _db.SaveChanges();

            // Seed States/Provinces in Database
            _db.StateOrProvinces.AddRange(StateOrProvinceSeedData.GetData());
            _db.SaveChanges();

            // Seed Baseball Leagues in Database
            _db.BaseballLeagues.AddRange(BaseballLeagueSeedData.GetData());
            _db.SaveChanges();

            // Seed Baseball Divisions in Database
            await BaseballDivisionsSeedData.GetData(_db);

            // Seed Baseball Teams in Database
            await BaseballTeamsSeedData.GetData(_db);
        }
    }
}
