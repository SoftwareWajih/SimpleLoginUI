using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum Explosives
    {
        [Display(Name = "Explosives with a mass explosion hazard")]
        A = 20,
        [Display(Name = "Explosives with a severe projection hazard")]
        B,
        [Display(Name = "Explosives with a fire, blast or projection hazard but not a mass explosion hazard")]
        C,
        [Display(Name = "Minor fire or projection hazard (includes ammunition and most consumer fireworks).")]
        D,
        [Display(Name = "An insensitive substance with a mass explosion hazard")]
        E,
        [Display(Name = "Extremely insensitive articles")]
        F
    }
}
