namespace PROPLASTICSAPI.Models.SHEQ
{
    //production status report
    public class PSRMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Shift { get; set; }
        public string U_CPQ { get; set; }//completed product quantity
        public string U_WIPPQ { get; set; }//work in progress product quantity
        public string U_QualityStatus { get; set; }
        public string U_DNC { get; set; }//description of non conformity
        public string U_ActionTaken { get; set; }
        public string U_QCSign { get; set; }//quality controller signature
        public string U_PHSSign { get; set; }//production head/supervisor signature
        public string U_PEFMSign { get; set; }//process engineer/fittings manager signature
    }
    public class PostPSRMDL
    {
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Shift { get; set; }
        public string U_CPQ { get; set; }//completed product quantity
        public string U_WIPPQ { get; set; }//work in progress product quantity
        public string U_QualityStatus { get; set; }
        public string U_DNC { get; set; }//description of non conformity
        public string U_ActionTaken { get; set; }
        public string U_QCSign { get; set; }//quality controller signature
        public string U_PHSSign { get; set; }//production head/supervisor signature
        public string U_PEFMSign { get; set; }//process engineer/fittings manager signature
    }
    public class PatchPSRMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Shift { get; set; }
        public string U_CPQ { get; set; }//completed product quantity
        public string U_WIPPQ { get; set; }//work in progress product quantity
        public string U_QualityStatus { get; set; }
        public string U_DNC { get; set; }//description of non conformity
        public string U_ActionTaken { get; set; }
        public string U_QCSign { get; set; }//quality controller signature
        public string U_PHSSign { get; set; }//production head/supervisor signature
        public string U_PEFMSign { get; set; }//process engineer/fittings manager signature
    }
}