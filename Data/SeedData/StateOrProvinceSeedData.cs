using BaseballAnalysisTool.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data.SeedData
{
    public class StateOrProvinceSeedData
    {
        public static StateOrProvince[] GetData()
        {
            var stateOrProvinces = new StateOrProvince[]
            {
                new StateOrProvince{Name="Alabama"}, 
                new StateOrProvince{Name="Alaska"}, 
                new StateOrProvince{Name="Arizona"},
                new StateOrProvince{Name="Arkansas"},
                new StateOrProvince{Name="California"},
                new StateOrProvince{Name="Colorado"},
                new StateOrProvince{Name="Connecticut"},
                new StateOrProvince{Name="Delaware"},
                new StateOrProvince{Name="Florida"},
                new StateOrProvince{Name="Georgia"},
                new StateOrProvince{Name="Hawaii"},
                new StateOrProvince{Name="Idaho"},
                new StateOrProvince{Name="Illinois"},
                new StateOrProvince{Name="Indiana"},
                new StateOrProvince{Name="Iowa"},
                new StateOrProvince{Name="Kansas"},
                new StateOrProvince{Name="Kentucky"},
                new StateOrProvince{Name="Louisiana"},
                new StateOrProvince{Name="Maine"},
                new StateOrProvince{Name="Maryland"},
                new StateOrProvince{Name="Massachusetts"},
                new StateOrProvince{Name="Michigan"},
                new StateOrProvince{Name="Minnesota"},
                new StateOrProvince{Name="Mississippi"},
                new StateOrProvince{Name="Missouri"},
                new StateOrProvince{Name="Montana"},
                new StateOrProvince{Name="Nebraska"},
                new StateOrProvince{Name="Nevada"},
                new StateOrProvince{Name="New Hampshire"}, 
                new StateOrProvince{Name="New Jersey"},
                new StateOrProvince{Name="New Mexico"},
                new StateOrProvince{Name="New York"},
                new StateOrProvince{Name="North Carolina"},
                new StateOrProvince{Name="North Dakota"},
                new StateOrProvince{Name="Ohio"},
                new StateOrProvince{Name="Oklahoma"},
                new StateOrProvince{Name="Oregon"},
                new StateOrProvince{Name="Pennsylvania"},
                new StateOrProvince{Name="Rhode Island"},
                new StateOrProvince{Name="South Carolina"},
                new StateOrProvince{Name="South Dakota"},
                new StateOrProvince{Name="Tennessee"},
                new StateOrProvince{Name="Texas"},
                new StateOrProvince{Name="Utah"},
                new StateOrProvince{Name="Vermont"},
                new StateOrProvince{Name="Virginia"},
                new StateOrProvince{Name="Washington"},
                new StateOrProvince{Name="West Virginia"},
                new StateOrProvince{Name="Wisconsin"},
                new StateOrProvince{Name="Wyoming"},
                new StateOrProvince{Name="District of Columbia"},
                new StateOrProvince{Name="Ontario (CA)"}
            };

            return stateOrProvinces;
        }
    }
}
