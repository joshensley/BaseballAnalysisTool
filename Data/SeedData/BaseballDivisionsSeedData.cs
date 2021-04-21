using BaseballAnalysisTool.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data.SeedData
{
    public class BaseballDivisionsSeedData
    {
        public async static Task GetData(ApplicationDbContext _db)
        {
            int americanLeagueID = (await _db.BaseballLeagues
                .FirstOrDefaultAsync(x => x.Name == "American League")).ID;

            int nationalLeagueID = (await _db.BaseballLeagues
                .FirstOrDefaultAsync(x => x.Name == "National League")).ID;

            var baseballDivisions = new BaseballDivision[]
            {
                new BaseballDivision{Name="American League East ",BaseballLeagueID=americanLeagueID},
                new BaseballDivision{Name="American League Central",BaseballLeagueID=americanLeagueID},
                new BaseballDivision{Name="American League West",BaseballLeagueID=americanLeagueID},
                new BaseballDivision{Name="National League East",BaseballLeagueID=nationalLeagueID},
                new BaseballDivision{Name="National League Central",BaseballLeagueID=nationalLeagueID},
                new BaseballDivision{Name="National League West",BaseballLeagueID=nationalLeagueID},
            };

            _db.BaseballDivisions.AddRange(baseballDivisions);
            _db.SaveChanges();

        }

    }
}
