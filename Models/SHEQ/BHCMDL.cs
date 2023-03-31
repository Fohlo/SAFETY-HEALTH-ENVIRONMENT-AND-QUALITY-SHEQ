using System.Collections.Generic;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class BHCMDL
    {
        public int DocNum { get; set; }
        public string U_Status { get; set; }
        public string U_ProductionDescription { get; set; }
        public string U_ThreadType { get; set; }
        public string U_Date { get; set; }
        public string U_Remarks { get; set; }
        public string U_OperatorName { get; set; }
        public string U_OPSign { get; set; }
        public List<BHClinescollection> BHCLINECollection { get; set; }

        public class BHClinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_LeadLength { get; set; }
            public float U_Pitch { get; set; }
            public float U_ThreadDepth { get; set; }
            public float U_ODID { get; set; }
            public float U_ThreadPortion { get; set; }
        }
    }

    public class PostBHCMDL
    {
        public string U_Status { get; set; }
        public string U_ProductionDescription { get; set; }
        public string U_ThreadType { get; set; }
        public string U_Date { get; set; }
        public string U_Remarks { get; set; }
        public string U_OperatorName { get; set; }
        public string U_OPSign { get; set; }
        public List<BHClinescollection> BHCLINECollection { get; set; }

        public class BHClinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_LeadLength { get; set; }
            public float U_Pitch { get; set; }
            public float U_ThreadDepth { get; set; }
            public float U_ODID { get; set; }
            public float U_ThreadPortion { get; set; }
        }
    }
    public class PatchBHCMDL
    {
        public string U_Status { get; set; }
        public string U_ProductionDescription { get; set; }
        public string U_ThreadType { get; set; }
        public string U_Date { get; set; }
        public string U_Remarks { get; set; }
        public string U_OperatorName { get; set; }
        public string U_OPSign { get; set; }
        public List<BHClinescollection> BHCLINECollection { get; set; }

        public class BHClinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_LeadLength { get; set; }
            public float U_Pitch { get; set; }
            public float U_ThreadDepth { get; set; }
            public float U_ODID { get; set; }
            public float U_ThreadPortion { get; set; }
        }
    }
}