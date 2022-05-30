// -----------------------------------------------------------------------
//  <copyright file="ZiiDmsMenus.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Models.Menus
{
    using System.Collections.Generic;

    public class ZiiDmsMenus : IZtMenu
    {
        public readonly List<ZtMenuItem> ziidmsmenu = new List<ZtMenuItem>();

        public ZiiDmsMenus()
        {
            // create the static menu
            // Major Units
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(0, 0, "majorunits"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(1, 0, "majorunitsinvoice", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(2, 0, "majorunitslist", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(3, 0, "muordering", typeof (int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(4, 0, "mureceiving", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(5, 0, "mumanagement", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(6, 5, "muinventory", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(7, 5, "mutransfer", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(8, 5, "modelmanagement"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(9, 5, "mucategory", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(10, 5, "mupackage", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(11, 5, "muincentives", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(12, 5, "mufandi", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(20, 0, "mureports", typeof(int)));

            // parts
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(100, 100, "parts"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(101, 100, "partsinvoice", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(102, 100, "partsinvoicelist", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(103, 100, "partsordering", typeof (int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(104, 100, "partsreveiving",typeof (int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(105, 100, "partsmanagement"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(106, 105, "partsinventory", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(107, 105, "partsreceivetransfer", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(108, 105, "partsrequesttransfer", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(109, 105, "partssupplierreturn", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(110, 105, "partsphysicalinventory", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(111, 105, "partscategory", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(112, 105, "partsseasonalordering", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(113, 105, "partsprofitmarginrules", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(120, 100, "partsreports", typeof(int)));

            // service
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(200, 200, "service"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(201, 200, "serviceinvoicing", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(202, 200, "serviceinvoicelist", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(203, 200, "servicewarrantyprocessing", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(204, 200, "servicemanagement"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(210, 204, "servicestandardjobtemplate", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(211, 204, "servicelabor", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(212, 204, "servicesubletlabor", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(213, 204, "servicetechnitiontimeclock", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(220, 200, "servicereports", typeof(int)));

            // accounting
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(300, 300, "accounting"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(301, 300, "accountinggeneralledger"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(302, 301, "accountingjournalentry", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(303, 301, "accountingsearchtransactions", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(304, 301, "accountingviewscheduleaccounts", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(304, 301, "accountingchartofaccounts", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(310, 300, "accountingpayables"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(311, 310, "accountingpackingslips", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(312, 310, "accountingcreatebills", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(313, 310, "accountingpaybills", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(314, 310, "accountingquickbills", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(315, 310, "accountingaddcreditcard", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(316, 310, "accountingvendorinquiry", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(317, 300, "accountingprintchecks"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(320, 317, "accountingreceivables", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(321, 317, "accountingreceivepayment", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(322, 317, "accountingarcustomerinquiry", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(323, 317, "accountingstatements", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(330, 300, "accountingcashinbank"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(331, 330, "accountingreconcile", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(332, 330, "accountingtransfers", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(333, 330, "accountingbankdeposits", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(340, 300, "accountingmaintenance"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(341, 340, "accountingvendors", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(342, 340, "accountingpaymentmethods", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(343, 340, "accountingterms", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(344, 340, "accountingimportpayrollje", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(345, 340, "accountingrecurringtransactions", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(346, 340, "accountingdepartments", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(347, 340, "accountingtimeclockmanagement", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(350, 300, "accountingreports", typeof(int)));

            // cashier
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(400, 400, "cashier"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(401, 400, "cashiermiscreceipts", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(402, 400, "cashierreceivepayments", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(403, 400, "cashieropenclosecashier", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(404, 400, "cashiermanagement", typeof(int)));

            // contacts
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(500, 500, "contacts"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(501, 500, "contactscustomers", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(502, 500, "contactsemployees", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(503, 500, "contactssuppliers", typeof(int)));

            // misc
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(600, 600, "misc"));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(601, 600, "miscdealershipsettings", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(602, 600, "miscfees", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(603, 600, "miscmisc", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(604, 600, "miscnonstockcategories", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(605, 600, "miscmassupdate", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(606, 600, "misclabelprinting", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(607, 600, "misclabeleditor", typeof(int)));
            ziidmsmenu.Add(ZtMenuItem.MakeMenuItem(608, 600, "miscdealershipsetup", typeof(int)));

        }

        public List<ZtMenuItem> GetPlatformMenu()
        {
            return ziidmsmenu;
        }
    }
}
