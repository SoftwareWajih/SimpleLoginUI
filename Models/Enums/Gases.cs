using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum Gases
    {
        [Display(Name = "Flammable Gas")]
        A = 21,
        [Display(Name = "Non-Flammable Gases")]
        B,
        [Display(Name = "Poisonous Gases")]
        C
    }
}
