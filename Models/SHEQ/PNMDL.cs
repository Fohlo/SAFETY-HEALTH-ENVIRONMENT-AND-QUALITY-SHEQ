namespace PROPLASTICSAPI.Models.SHEQ
{
    //production notification
    public class PNMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_PONo { get; set; }//producrion order number
        public string U_ProdMaterial { get; set; }//product or material
        public string U_Notifier { get; set; }//person raising notification
        public string U_DateReceived { get; set; }//date when material was received
        public string U_Date { get; set; }//date when record was added
        public string U_Machine { get; set; }//date when record was added
        public string U_Comment { get; set; }//comment reserved in case there is need to

    }
    public class PostPNMDL
    {
        public string U_Status { get; set; }
        public string U_PONo { get; set; }//producrion order number
        public string U_ProdMaterial { get; set; }//product or material
        public string U_Notifier { get; set; }//person raising notification
        public string U_DateReceived { get; set; }//date when material was received
        public string U_Date { get; set; }//date when record was added
        public string U_Machine { get; set; }//date when record was added
        public string U_Comment { get; set; }//comment reserved in case there is need to

    }
    public class PatchPNMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_PONo { get; set; }//producrion order number
        public string U_ProdMaterial { get; set; }//product or material
        public string U_Notifier { get; set; }//person raising notification
        public string U_DateReceived { get; set; }//date when material was received
        public string U_Date { get; set; }//date when record was added
        public string U_Machine { get; set; }//date when record was added
        public string U_Comment { get; set; }//comment reserved in case there is need to

    }
}