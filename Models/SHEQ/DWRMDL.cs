namespace PROPLASTICSAPI.Models.SHEQ
{
    //deviation/waiver request
    public class DWRMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_DateIssued { get; set; }
        public string U_NCRNo { get; set; }
        public string U_ProductType { get; set; }
        public string U_Shift { get; set; }//shift affected
        public string U_ReqDpt { get; set; }//requesting department
        public string U_Name { get; set; }//name of requestor
        public string U_TypeOfRequest { get; set; }
        public string U_Criticality { get; set; }
        public string U_QtyAffected { get; set; }//quantity affected
        public string U_PDAF { get; set; }//products dates affected from
        public string U_PDAT { get; set; }//products dates affected to
        public string U_DNC { get; set; }//details of non conformance
        public string U_EDW { get; set; }//explanation of deviation or waiver
        public string U_SignedBy { get; set; }
        public string U_Position { get; set; }//position of signee
        public string U_DateSigned { get; set; }
    }
    public class PostDWRMDL
    {
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_DateIssued { get; set; }
        public string U_NCRNo { get; set; }
        public string U_ProductType { get; set; }
        public string U_Shift { get; set; }//shift affected
        public string U_ReqDpt { get; set; }//requesting department
        public string U_Name { get; set; }//name of requestor
        public string U_TypeOfRequest { get; set; }
        public string U_Criticality { get; set; }
        public string U_PDAF { get; set; }//products dates affected from
        public string U_PDAT { get; set; }//products dates affected to
        public string U_DNC { get; set; }//details of non conformance
        public string U_EDW { get; set; }//explanation of deviation or waiver
        public string U_SignedBy { get; set; }
        public string U_Position { get; set; }//position of signee
        public string U_DateSigned { get; set; }
    }
    public class PatchDWRMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_DateIssued { get; set; }
        public string U_NCRNo { get; set; }
        public string U_ProductType { get; set; }
        public string U_Shift { get; set; }//shift affected
        public string U_ReqDpt { get; set; }//requesting department
        public string U_Name { get; set; }//name of requestor
        public string U_TypeOfRequest { get; set; }
        public string U_Criticality { get; set; }
        public string U_PDAF { get; set; }//products dates affected from
        public string U_PDAT { get; set; }//products dates affected to
        public string U_DNC { get; set; }//details of non conformance
        public string U_EDW { get; set; }//explanation of deviation or waiver
        public string U_SignedBy { get; set; }
        public string U_Position { get; set; }//position of signee
        public string U_DateSigned { get; set; }
    }
}