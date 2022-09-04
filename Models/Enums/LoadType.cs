using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum LoadType
    {
        [Display(Name = "Containerized")]
        Containerized = 1,
        [Display(Name = "Break Bulk")]
        BreakBulk = 3,
        [Display(Name = "Bulk")]
        Bulk
    }
}
