using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum FlammableSolids
    {
        [Display(Name = "Flammable Solids")]
        A = 23,
        [Display(Name = "Spontaneously Combustible Solids")]
        B,
        [Display(Name = "Dangerous when Wet")]
        C
    }
}
