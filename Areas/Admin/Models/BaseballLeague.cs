using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Areas.Admin.Models
{
    public class BaseballLeague
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "League name is required")]
        [Display(Name = "League Name")]
        [MaxLength(256)]
        public string Name { get; set; }

        public ICollection<BaseballDivision> BaseballDivisions { get; set; }
        public ICollection<BaseballTeam> BaseballTeams { get; set; }
    }
}
