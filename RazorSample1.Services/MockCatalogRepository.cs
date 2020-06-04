using RazorSample1.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace RazorSample1.Services
{
    public class MockCatalogRepository : IItemRepository
    {
        private List<Item> _itemList;

        public MockCatalogRepository()
        {
            _itemList = new List<Item>()
            {
                new Item() {Id=1, Title="RTE Monthly Mismatches",
                    Summary="Registration supervisors can use the RTE Monthly Mismatches report to monitor front desk productivity and follow up with registrars about incorrect data entry patterns. Interface administrators can also use this report to review query information to determine whether to adjust your build based on the information that payors and clearinghouses send.",
                    ReportingTool = Models.Enums.ReportingTools.ReportingWorkbench,
                    Consumers = new List<Models.Enums.Consumers>() { Models.Enums.Consumers.BID, Models.Enums.Consumers.EndUser},
                    Product = Models.Enums.Products.Epic,
                    Topics = new List<Models.Enums.Topics>() { Models.Enums.Topics.HospitalOps, Models.Enums.Topics.PhysicianOps },
                    Confidence = Models.Enums.DataConfidence.Validated,
                    ScreenShotPath = "rte_monthly_mismatches.png",
                    UsageCount = 423
                },
                
                new Item() {Id=2, Title="Obstetrics Nurse Manager In House Dashboard",
                    Summary="Nurse managers in OB departments can monitor information about currently admitted patients and their care on the Obstetrics Nurse Manager In House Dashboard.",
                    ReportingTool = Models.Enums.ReportingTools.Radar,
                    Consumers = new List<Models.Enums.Consumers>() { Models.Enums.Consumers.EndUser},
                    Product = Models.Enums.Products.Epic,
                    Topics = new List<Models.Enums.Topics>() { Models.Enums.Topics.IPClinical, Models.Enums.Topics.IPQuality, Models.Enums.Topics.PhysicianClinical },
                    Confidence = Models.Enums.DataConfidence.Unverified,
                    ScreenShotPath = "ob_nurse_manager_db.png",
                    UsageCount =34
                },

                new Item() {Id=2, Title="Report with a really long title that should be banned from occuring",
                    Summary="This report identifies reports that have really long titles that mess up the report catalog when displaying it.  ",
                    ReportingTool = Models.Enums.ReportingTools.RawSQL,
                    Consumers = new List<Models.Enums.Consumers>() { Models.Enums.Consumers.EndUser},
                    Product = Models.Enums.Products.Infor,
                    Topics = new List<Models.Enums.Topics>() { Models.Enums.Topics.IPClinical, Models.Enums.Topics.IPQuality, Models.Enums.Topics.PhysicianClinical },
                    Confidence = Models.Enums.DataConfidence.Unverified,
                    UsageCount =96,
                    Sensitive = true
                },
            };
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _itemList;
        }
    }
}
