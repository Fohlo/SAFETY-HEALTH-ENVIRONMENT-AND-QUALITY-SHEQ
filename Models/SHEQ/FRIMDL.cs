using System.Collections.Generic;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class FRIMDL
    {
        public int? DocNum { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Time { get; set; }
        public string U_Department { get; set; }
        public string U_Workissue { get; set; }
        public string U_Remarks { get; set; }
        public string U_QAName { get; set; }
        public string U_QASign { get; set; }
        public string U_DispatchName { get; set; }
        public string U_DSign { get; set; }
        public List<ItemLinesCollections> ITEMLINESCollections { get; set; }
        public List<FRIlinesCollections> FRILINESCollection { get; set; }

        public class ItemLinesCollections
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Item { get; set; }
            public string U_Yes { get; set; }
            public string U_No { get; set; }
        }

        public class FRIlinesCollections
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_ProductName { get; set; }
            public string U_QuantityReleased { get; set; }
            public string U_JobNumber { get; set; }
            public string U_ProductCode { get; set; }
            public string U_QCPass { get; set; }


        }
    }
    public class PostFRIMDL
    {
        public string U_Status { get; set; }
        public string U_Time { get; set; }
        public string U_Department { get; set; }
        public string U_Workissue { get; set; }
        public string U_Remarks { get; set; }
        public string U_QAName { get; set; }
        public string U_QASign { get; set; }
        public string U_DispatchName { get; set; }
        public string U_DSign { get; set; }
        public List<ItemLinesCollections> ITEMLINESCollections { get; set; }
        public List<FRIlinesCollections> FRILINESCollection { get; set; }

        public class ItemLinesCollections
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Item { get; set; }
            public string U_Yes { get; set; }
            public string U_No { get; set; }
        }

        public class FRIlinesCollections
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_ProductName { get; set; }
            public string U_QuantityReleased { get; set; }
            public string U_JobNumber { get; set; }
            public string U_ProductCode { get; set; }
            public string U_QCPass { get; set; }


        }
    }
    public class PatchFRIMDL
    {
        public string U_Status { get; set; }
        public string U_Time { get; set; }
        public string U_Department { get; set; }
        public string U_Workissue { get; set; }
        public string U_Remarks { get; set; }
        public string U_QAName { get; set; }
        public string U_QASign { get; set; }
        public string U_DispatchName { get; set; }
        public string U_DSign { get; set; }
        public List<ItemLinesCollections> ITEMLINESCollections { get; set; }
        public List<FRIlinesCollections> FRILINESCollection { get; set; }

        public class ItemLinesCollections
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Item { get; set; }
            public string U_Yes { get; set; }
            public string U_No { get; set; }
        }

        public class FRIlinesCollections
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_ProductName { get; set; }
            public string U_QuantityReleased { get; set; }
            public string U_JobNumber { get; set; }
            public string U_ProductCode { get; set; }
            public string U_QCPass { get; set; }


        }
    }
}