using BaseballAnalysisTool.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data.SeedData
{
    public class CountrySeedData
    {
        public static Country[] GetData()
        {
            var countries = new Country[]
            {
                new Country{Name="United States"}, // 1
                new Country{Name="Canada"} // 2
            };

            return countries;

        }

        

    }
}
