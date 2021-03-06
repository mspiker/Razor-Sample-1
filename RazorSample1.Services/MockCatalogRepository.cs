﻿using RazorSample1.Models;
using System.Collections.Generic;
using System.Linq;

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
                    Confidence = Models.Enums.DataConfidence.Certified,
                    ScreenShotPath = "ob_nurse_manager_db.png",
                    UsageCount =34
                },

                new Item() {Id=3, Title="Report with a really long title that should be banned from occuring",
                    Summary="This report identifies reports that have really long titles that mess up the report catalog when displaying it.  ",
                    ReportingTool = Models.Enums.ReportingTools.RawSQL,
                    Consumers = new List<Models.Enums.Consumers>() { Models.Enums.Consumers.EndUser},
                    Product = Models.Enums.Products.Infor,
                    Topics = new List<Models.Enums.Topics>() { Models.Enums.Topics.IPClinical, Models.Enums.Topics.IPQuality, Models.Enums.Topics.PhysicianClinical },
                    Confidence = Models.Enums.DataConfidence.Unverified,
                    UsageCount =96,
                    Sensitive = true
                },

                new Item() {Id=4, Title="Omron Blood Pressure Log",
                    Summary="This is an example of a report that shows whe the blood pressure SYS and DIA <> 0 in the reading. ",
                    ReportingTool = Models.Enums.ReportingTools.ReportingWorkbench,
                    Consumers = new List<Models.Enums.Consumers>() { Models.Enums.Consumers.EndUser, Models.Enums.Consumers.BID},
                    Product = Models.Enums.Products.Epic,
                    Topics = new List<Models.Enums.Topics>() { Models.Enums.Topics.OPClinical, Models.Enums.Topics.IPQuality, Models.Enums.Topics.PhysicianClinical },
                    UsageCount =2212,
                    Sensitive = false,
                    Confidence = Models.Enums.DataConfidence.Reviewed
                },

                new Item() {Id=5, Title="Patient Accounts Receivable Balances <> $0",
                    Summary="This is a report that shows all patinet balances that are <> to 0.",
                    ReportingTool = Models.Enums.ReportingTools.ReportingWorkbench,
                    Consumers = new List<Models.Enums.Consumers>() { Models.Enums.Consumers.EndUser, Models.Enums.Consumers.BID},
                    Product = Models.Enums.Products.Epic
                },

                new Item() {Id=6, Title="Report with minimal parameters",
                    Summary="This is a report that shows all patinet balances that are <> to 0.",
                    ScreenShotPath = "bigscreen_shot.png"
                },
            };
        }

        public Item Add(Item newItem)
        {
            newItem.Id = _itemList.Max(i => i.Id) + 1;
            _itemList.Add(newItem);
            return newItem;
        }

        public IEnumerable<Item> GetAllItems(int resultsPerPage, int pageOffset)
        {
            //_itemList.Add(new Item()
            //{
            //    Id = 100 + pageOffset,
            //    Title = "Page placeholder " + pageOffset,
            //    Summary = "This is used to test paging.",
            //    ReportingTool = Models.Enums.ReportingTools.ReportingWorkbench
            //});
            return _itemList;
        }

        public Item GetItem(int id)
        {
            return _itemList.FirstOrDefault(i => i.Id == id);
        }

        public Item Update(Item updatedItem)
        {
            Item item = _itemList.FirstOrDefault(i => i.Id == updatedItem.Id);
            if (item != null)
            {
                item.Title = updatedItem.Title;
                item.Summary = updatedItem.Summary;
                item.ReportingTool = updatedItem.ReportingTool;
                item.Consumers = updatedItem.Consumers;
                item.Product = updatedItem.Product;
                item.Confidence = updatedItem.Confidence;
                item.ScreenShotPath = updatedItem.ScreenShotPath;
                item.ReportFilePath = updatedItem.ReportFilePath;
                item.Sensitive = updatedItem.Sensitive;
            }
            return item;
        }
    }
}
