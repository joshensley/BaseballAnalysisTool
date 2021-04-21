using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Areas.Admin.Models
{
    public class BaseballTeam
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [Display(Name = "Location")]
        [MaxLength(256)]
        public string Location { get; set; }

        [Required(ErrorMessage = "Nickname is required.")]
        [Display(Name = "Nickname")]
        [MaxLength(256)]
        public string NickName { get; set; }

        [Display(Name = "Team Name")]
        public string TeamName 
        { 
            get { return string.Format("{0} {1}", Location, NickName); }
        }

        [Required(ErrorMessage = "Stadium is required.")]
        [Display(Name = "Stadium")]
        [MaxLength(256)]
        public string StadiumName { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City")]
        public string City { get; set; }

        // StateOrProvince
        [Required(ErrorMessage = "State/Province is required")]
        [Display(Name = "State/Province")]
        public int StateOrProvinceID { get; set; }

        [Display(Name = "State/Province")]
        public StateOrProvince StateOrProvince { get; set; }

        // Country
        [Required(ErrorMessage = "Country is Required")]
        [Display(Name = "Country")]
        public int CountryID { get; set; }

        [Display(Name = "Country")]
        public Country Country { get; set; }


        // BaseballDivision
        [Required(ErrorMessage = "Division is Required")]
        [Display(Name = "Division")]
        public int BaseballDivisionID { get; set; }

        [Display(Name = "Division")]
        public BaseballDivision BaseballDivision { get; set; }

        // BaseballLeague
        [Display(Name = "League")]
        public int? BaseballLeagueID { get; set; }

        [Display(Name = "League")]
        public BaseballLeague BaseballLeague { get; set; }

        [Display(Name = "Image Path")]
        public string TeamLogoImagePath { get; set; }

    }
}
