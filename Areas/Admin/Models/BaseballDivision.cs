using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Areas.Admin.Models
{
    public class BaseballDivision
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Division Name is Required")]
        [Display(Name = "Division name")]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Baseball League is Required")]
        public int BaseballLeagueID { get; set; }
        public BaseballLeague BaseballLeague { get; set; }

        public ICollection<BaseballTeam> BaseballTeams { get; set; }
    }
}
