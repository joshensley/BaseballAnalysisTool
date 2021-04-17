using BaseballAnalysisTool.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data.SeedData
{
    public class BaseballLeagueSeedData
    {
        public static BaseballLeague[] GetData()
        {
            var baseballLeague = new BaseballLeague[]
            {
                new BaseballLeague{Name="American League"},
                new BaseballLeague{Name="National League"}
            };

            return baseballLeague;
        } 

    }
}
