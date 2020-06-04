using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorSample1.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="A title is required"),
            MinLength(5, ErrorMessage ="The title must contain at least 5 characters."),
            Display(Name ="Title", Description ="Please provide a brief title of the solution.")]
        public string Title { get; set; }
        
        [Required(ErrorMessage ="A summary is required"),
            MinLength(15, ErrorMessage ="A summary must contain at least 15 characters."),
            Display(Name ="Summary", Description ="Describe your solution's purpose, output, grouping levels, parameters, custome tables, and other relevant information.")
            ]
        public string Summary { get; set; }
        
        [Display(Name ="Reporting Tool", Description ="Select the reporting tool used to develop this solution.")]
        public Enums.ReportingTools ReportingTool { get; set; }
        public List<Enums.Consumers> Consumers { get; set; }
        public Enums.Products Product { get; set; }
        public List<Enums.Topics> Topics { get; set; }
        public Enums.DataConfidence Confidence { get; set; }

        [Display(Name ="Screen Shot", Description ="Provide a screen shot of the reporting solution.  Do not include protected health information in the screen shot")]
        public string ScreenShotPath { get; set; }
        
        [Display(Name ="Report File", Description ="Provide the file containing the reporting solution.  Do not include saved data with the actual solution file.")]
        public string ReportFilePath { get; set; }

        public int UsageCount { get; set; }
        public bool Sensitive { get; set; }

    }
}
