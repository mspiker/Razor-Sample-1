using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace RazorSample1.Models.Enums
{
    public enum ReportingTools
    {
        [Display(Name ="Reporting Workbench")]
        ReportingWorkbench=1,
        [Display(Name ="SAP Crystal Report")]
        SAPCrystal=2,
        [Display(Name ="SQL")]
        RawSQL = 3,
        [Display(Name ="Radar Dashboard")]
        Radar = 4
    }
}
