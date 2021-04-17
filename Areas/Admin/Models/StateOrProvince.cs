using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Areas.Admin.Models
{
    public class StateOrProvince
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "State/Province is required.")]
        [Display(Name = "State/Province")]
        [MaxLength(256)]
        public string Name { get; set; }
    }
}
