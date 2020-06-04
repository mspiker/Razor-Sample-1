using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorSample1.Models.Enums
{
    public enum Products
    {
        [Display(Name ="Epic")]
        Epic = 1,
        [Display(Name ="Infor")]
        Infor = 2
    }
}
