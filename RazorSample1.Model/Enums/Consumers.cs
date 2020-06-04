using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorSample1.Models.Enums
{
    public enum Consumers
    {
        [Display(Name ="Business Intelligence Developer")]
        BID = 1,
        [Display(Name ="Data Analyst")]
        DataAnalyst=2,
        [Display(Name ="End User")]
        EndUser = 3,
        [Display(Name ="Executive")]
        Executive = 4,
        [Display(Name ="Manager")]
        Manager = 5,
        [Display(Name ="Project Team")]
        ProjectTeam = 6
    }
}
