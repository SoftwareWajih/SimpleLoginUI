using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum HazardousClassify
    {
        Explosives = 20,
        Gases,
        [Display(Name = "Flammable Liquids")]
        FlammableLiquids,
        [Display(Name = "Flammable Solids")]
        FlammableSolids,
        [Display(Name = "Toxic and Infectious Substances")]
        ToxicAndInfectiousSubstances,
        [Display(Name = "Radioactive substances")]
        Radioactivesubstances,
        [Display(Name = "Corrosive substances")]
        Corrosivesubstances,
        Miscellaneous
    }
}
