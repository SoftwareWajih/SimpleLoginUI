using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum FlammableLiquids
    {
        [Display(Name = "Flammable Liquids")]
        A = 22,
        [Display(Name = "Combustible (Alternate Placard)")]
        B,
        [Display(Name = "Fuel Oil (Alternate Placard)")]
        C,
        [Display(Name = "Gasoline (Alternate Placard)")]
        D
    }
}
