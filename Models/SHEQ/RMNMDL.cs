namespace PROPLASTICSAPI.Models.SHEQ
{ 
    //raw material notification
    public class RMNMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_BatchNo { get; set; }//batch number
        public string U_ProdMaterial { get; set; }//product or material
        public string U_SONumber { get; set; }//sales order number
        public string U_Notifier { get; set; }//person raising notification
        public string U_DateReceived { get; set; }//date when material was received
        public string U_Date { get; set; }//date when record was added
        public string U_Manufacturer { get; set; }//manufacturer name
        public string U_Country { get; set; }//country of origin
        public string U_Comment { get; set; }//comment reserved in case there is need to

    }
    public class PostRMNMDL
    {
        public string U_Status { get; set; }
        public string U_BatchNo { get; set; }//batch number
        public string U_ProdMaterial { get; set; }//product or material
        public string U_SONumber { get; set; }//sales order number
        public string U_Notifier { get; set; }//person raising notification
        public string U_DateReceived { get; set; }//date when material was received
        public string U_Date { get; set; }//date when record was added
        public string U_Manufacturer { get; set; }//manufacturer name
        public string U_Country { get; set; }//country of origin
        public string U_Comment { get; set; }//comment reserved in case there is need to

    }
    public class PatchRMNMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_BatchNo { get; set; }//batch number
        public string U_ProdMaterial { get; set; }//product or material
        public string U_SONumber { get; set; }//sales order number
        public string U_Notifier { get; set; }//person raising notification
        public string U_DateReceived { get; set; }//date when material was received
        public string U_Date { get; set; }//date when record was added
        public string U_Manufacturer { get; set; }//manufacturer name
        public string U_Country { get; set; }//country of origin
        public string U_Comment { get; set; }//comment reserved in case there is need to

    }
}