using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.Models.Engineering
{
    public class DailyChecklistMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_ChecklistNo { get; set; }
        public string U_Day { get; set; }
        public string U_WeekNo { get; set; }
        public string U_Date { get; set; }
        public string U_Artisan { get; set; }
        public string U_Location { get; set; }
        public string U_Machine { get; set; }
        public string U_MachineNo { get; set; }
        public string U_Remarks { get; set; }
        public string U_ElectSig { get; set; } //electrical engineer signature
        public string U_ElectSigDate { get; set; }//electrical engineer signature date
        public string U_MechSig { get; set; }//mechanical engineer signature
        public string U_MechSigDate { get; set; } //mechanical engineer signature date
        public string U_EngMgrSig { get; set; }//engineering manager signature
        public string U_EngMgrSigDate { get; set; } //engineering manager signature date
        public List<Dailychcklstcollection> DAILYCHCKLSTSCollection { get; set; }

        public class Dailychcklstcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_CheckItem { get; set; }
            public string U_Checked { get; set; }
            public string U_Comment { get; set; }
        }
    }
    public class PostDailyChecklistMDL
    {
        public string U_Status { get; set; }
        public string U_ChecklistNo { get; set; }
        public string U_Day { get; set; }
        public string U_WeekNo { get; set; }
        public string U_Date { get; set; }
        public string U_Artisan { get; set; }
        public string U_Location { get; set; }
        public string U_Machine { get; set; }
        public string U_MachineNo { get; set; }
        public string U_Remarks { get; set; }
        public string U_ElectSig { get; set; } //electrical engineer signature
        public string U_ElectSigDate { get; set; }//electrical engineer signature date
        public string U_MechSig { get; set; }//mechanical engineer signature
        public string U_MechSigDate { get; set; } //mechanical engineer signature date
        public string U_EngMgrSig { get; set; }//engineering manager signature
        public string U_EngMgrSigDate { get; set; } //engineering manager signature date
        public List<Dailychcklstcollection> DAILYCHCKLSTSCollection { get; set; }

        public class Dailychcklstcollection
        {
            public string U_CheckItem { get; set; }
            public string U_Checked { get; set; }
            public string U_Comment { get; set; }
        }
    }
    public class PatchDailyChecklistMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_ChecklistNo { get; set; }
        public string U_Day { get; set; }
        public string U_WeekNo { get; set; }
        public string U_Date { get; set; }
        public string U_Artisan { get; set; }
        public string U_Location { get; set; }
        public string U_Machine { get; set; }
        public string U_MachineNo { get; set; }
        public string U_Remarks { get; set; }
        public string U_ElectSig { get; set; } //electrical engineer signature
        public string U_ElectSigDate { get; set; }//electrical engineer signature date
        public string U_MechSig { get; set; }//mechanical engineer signature
        public string U_MechSigDate { get; set; } //mechanical engineer signature date
        public string U_EngMgrSig { get; set; }//engineering manager signature
        public string U_EngMgrSigDate { get; set; } //engineering manager signature date
        public List<Dailychcklstcollection> DAILYCHCKLSTSCollection { get; set; }

        public class Dailychcklstcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_CheckItem { get; set; }
            public string U_Checked { get; set; }
            public string U_Comment { get; set; }
        }
    }
}