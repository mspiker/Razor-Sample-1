using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorSample1.Models.Enums
{
    public enum Topics
    {
        [Display(Name ="Inpatient Clinical")]
        IPClinical = 1,
        [Display(Name = "Outpatient Clinical")]
        OPClinical = 2,
        [Display(Name = "Ancillary Clinical")]
        AncClinical = 3,
        [Display(Name = "Physician Practice Clinical")]
        PhysicianClinical = 4,
        [Display(Name = "Physician Quality")]
        PhysicianQuality = 5,
        [Display(Name = "Inpatient Quality")]
        IPQuality = 6,
        [Display(Name = "Hospital Operations")]
        HospitalOps = 7,
        [Display(Name = "Physician Operations")]
        PhysicianOps = 8
    }
}
