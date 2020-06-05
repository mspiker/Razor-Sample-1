using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorSample1.Models.Enums
{
    public enum DataConfidence
    {
        [Display(Name ="Unverified", 
            Description ="This solution has not been reviewed by a subject matter expert and should be used with cation when making decisions.")]
        Unverified = 0,
        [Display(Name ="Reviewed", 
            Description ="Solution has been reviewed by a subject matter expert and through limited validation states it provides accurate results.")]
        Reviewed = 1,
        [Display(Name = "Validated", 
            Description = "Soution has been reviewed by a subject matter expert and has a high confidence that the results provided are accurate. ")]
        Validated = 2,
        [Display(Name = "Certified", 
            Description = "Multiple subject matter experts have reviewed this solution and through rigorus validation techniques determined results to be accurate.")]
        Certified = 3
    }
}
