namespace PROPLASTICSAPI.Models.SHEQ
{
    //Corrective Action Request
    public class CAMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_RequestNo { get; set; }
        public string U_Date { get; set; }
        public string U_IssuingDpt { get; set; }//Issuing department
        public string U_AssignedDpt { get; set; }//Assigned department
        public string U_ReqCategory { get; set; }//request category
        public string U_Originator { get; set; }
        public string U_PRA { get; set; }//Personnel responsible for action
        public string U_Recipient { get; set; }
        public string U_DNC { get; set; }//details of non-conformance
        public string U_RootCause { get; set; }
        public string U_Correction { get; set; }
        public string U_CAT { get; set; }//corrective action to be taken
        public string U_HOD { get; set; }//head of department
        public string U_DateComplete { get; set; }//completion date
        public string U_Verification { get; set; }
        public string U_DateVerified { get; set; }
        public string U_Signature { get; set; }
    }
    public class PostCAMDL
    {
        public string U_RequestNo { get; set; }
        public string U_Date { get; set; }
        public string U_IssuingDpt { get; set; }//Issuing department
        public string U_AssignedDpt { get; set; }//Assigned department
        public string U_ReqCategory { get; set; }//request category
        public string U_Originator { get; set; }
        public string U_PRA { get; set; }//Personnel responsible for action
        public string U_Recipient { get; set; }
        public string U_DNC { get; set; }//details of non-conformance
        public string U_RootCause { get; set; }
        public string U_Correction { get; set; }
        public string U_CAT { get; set; }//corrective action to be taken
        public string U_HOD { get; set; }//head of department
        public string U_DateComplete { get; set; }//completion date
        public string U_Verification { get; set; }
        public string U_DateVerified { get; set; }
        public string U_Signature { get; set; }
    }
    public class PatchCAMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_RequestNo { get; set; }
        public string U_Date { get; set; }
        public string U_IssuingDpt { get; set; }//Issuing department
        public string U_AssignedDpt { get; set; }//Assigned department
        public string U_ReqCategory { get; set; }//request category
        public string U_Originator { get; set; }
        public string U_PRA { get; set; }//Personnel responsible for action
        public string U_Recipient { get; set; }
        public string U_DNC { get; set; }//details of non-conformance
        public string U_RootCause { get; set; }
        public string U_Correction { get; set; }
        public string U_CAT { get; set; }//corrective action to be taken
        public string U_HOD { get; set; }//head of department
        public string U_DateComplete { get; set; }//completion date
        public string U_Verification { get; set; }
        public string U_DateVerified { get; set; }
        public string U_Signature { get; set; }
    }
}