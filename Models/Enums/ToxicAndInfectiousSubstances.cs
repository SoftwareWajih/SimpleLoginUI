using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum ToxicAndInfectiousSubstances
    {
        [Display(Name = "Poison")]
        A = 24,
        [Display(Name = "Biohazard")]
        B,
    }
}
