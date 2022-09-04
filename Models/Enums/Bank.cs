using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleLoginUI.Models
{
    public enum Bank
    {
        [Display(Name = "Bank Alfalah")]
        Alfalah = 1,
        [Display(Name = "Habib Bank Bank")]
        HBL
    }
}
