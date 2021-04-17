using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Areas.Admin.Models
{
    public class Country
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Country name is required.")]
        [Display(Name = "Country")]
        [MaxLength(256)]
        public string Name { get; set; }
    }
}
