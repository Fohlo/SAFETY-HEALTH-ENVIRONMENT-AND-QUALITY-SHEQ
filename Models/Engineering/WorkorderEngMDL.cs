using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.Models.Engineering
{
    public class WorkorderEngMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Notstatus { get; set; }
        public string U_Originator { get; set; }
        public string U_Natureofjob { get; set; }
        public string U_Description { get; set; }
        public string U_Department { get; set; }
        public string U_Plant { get; set; }
        public string U_Machine { get; set; }
        public string U_Subassemble { get; set; }
        public string U_Equipment { get; set; }
        public string U_Number { get; set; }
        public string U_Notnumber { get; set; }
        public string U_JobType { get; set; }
        public string U_FaultDate { get; set; }
        public string U_Faulttime { get; set; }
        public string U_Submissiondate { get; set; }
        public string U_Submissiontime { get; set; }
        public string U_SHEstatus { get; set; }
        public List<RequestCollection> REQUESTCollection { get; set; }
        public List<CorractiveCollection> CORRECTIVECollection { get; set; }
        public List<PreventiveCollection> PREVENTIVECollection { get; set; }
        public List<VerificationCollection> VERIFICATIONCollection { get; set; }
        public List<ArtisantaskCollection> ARTISANTASKCollection { get; set; }
        public List<SparesusedCollection> SPARESUSEDCollection { get; set; }
        public List<SupervisorverifictionCollection> SUPERVISORVERCollection { get; set; }
        public List<NotcommentsCollection> NOTCOMMENTSCollection { get; set; }
        public List<ConfirmationsCollection> CONFIRMATIONSCollection { get; set; }
        public List<SheverifyCollection> SHEQVERIFYCollection { get; set; }


        public class RequestCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Details { get; set; }
            public string U_Date { get; set; }
        }
        public class NotcommentsCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Comment { get; set; }
            public string U_Date { get; set; }
        }

        public class CorractiveCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Corrective { get; set; }
        }

        public class PreventiveCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Preventive { get; set; }
        }

        public class VerificationCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Originatorverified { get; set; }
            public string U_Originatorname { get; set; }
            public string U_Originatorhandovertime { get; set; }

            public string U_Comment { get; set; }
            public string U_Title { get; set; }
        }

        public class ArtisantaskCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Internalartisan { get; set; }
            public string U_Externalartisan { get; set; }
            public string U_Task { get; set; }
            public string U_Description { get; set; }
            public float U_Estimatedduration { get; set; }

        }

        public class ConfirmationsCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Internalartisan { get; set; }
            public string U_Externalartisan { get; set; }
            public string U_Jobtype { get; set; }
            public string U_Artisan { get; set; }
            public string U_Startdate { get; set; }
            public string U_Starttime { get; set; }
            public string U_Enddate { get; set; }
            public string U_Endtime { get; set; }
            public string U_Duration { get; set; }
        }

        public class SparesusedCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_ItemNo { get; set; }
            public string U_Description { get; set; }
            public string U_Inventory { get; set; }
            public string U_Uom { get; set; }
            public string U_Warehouse { get; set; }
            public float U_Quantity { get; set; }
            public string U_Artisan { get; set; }
        }

        public class SupervisorverifictionCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_JobAknowledged { get; set; }
            public string U_LockOutRequired { get; set; }
            public string U_Workpermitdone { get; set; }
            public string U_Workpermitnumber { get; set; }
            public string U_Workcentre { get; set; }
        }

        public class SheverifyCollection
        {
            public string U_Date { get; set; }
            public string U_Time { get; set; }
            public string U_Comment { get; set; }
            public string U_Status { get; set; }
            public string U_SheVerifier { get; set; }
        }
    }

    public class PostWorkorderEngMDL
    {
        public string U_Status { get; set; }
        public string U_Notstatus { get; set; }
        public string U_Originator { get; set; }
        public string U_Natureofjob { get; set; }
        public string U_Description { get; set; }
        public string U_Department { get; set; }
        public string U_Plant { get; set; }
        public string U_Machine { get; set; }
        public string U_Subassemble { get; set; }
        public string U_Equipment { get; set; }
        public string U_Number { get; set; }
        public string U_Notnumber { get; set; }
        public string U_JobType { get; set; }
        public string U_FaultDate { get; set; }
        public string U_Faulttime { get; set; }
        public string U_Submissiondate { get; set; }
        public string U_Submissiontime { get; set; }
      //  public string U_SHEstatus { get; set; }
        public List<RequestCollection> REQUESTCollection { get; set; }
        public List<CorractiveCollection> CORRECTIVECollection { get; set; }
        public List<PreventiveCollection> PREVENTIVECollection { get; set; }
        public List<VerificationCollection> VERIFICATIONCollection { get; set; }
        public List<ArtisantaskCollection> ARTISANTASKCollection { get; set; }
        public List<SparesusedCollection> SPARESUSEDCollection { get; set; }
        public List<SupervisorverifictionCollection> SUPERVISORVERCollection { get; set; }
        public List<NotcommentsCollection> NOTCOMMENTSCollection { get; set; }
        public List<ConfirmationsCollection> CONFIRMATIONSCollection { get; set; }


        public class RequestCollection
        {
            public string U_Details { get; set; }
            public string U_Date { get; set; }
        }
        public class NotcommentsCollection
        {

            public string U_Comment { get; set; }
            public string U_Date { get; set; }
        }

        public class CorractiveCollection
        {
            public string U_Corrective { get; set; }
        }

        public class PreventiveCollection
        {
            public string U_Preventive { get; set; }
        }

        public class VerificationCollection
        {

            public string U_Originatorverified { get; set; }
            public string U_Originatorname { get; set; }
            public string U_Originatorhandovertime { get; set; }
            public string U_Comment { get; set; }
            public string U_Title { get; set; }
        }

        public class ArtisantaskCollection
        {
            public string U_Internalartisan { get; set; }
            public string U_Externalartisan { get; set; }
            public string U_Task { get; set; }
            public string U_Description { get; set; }
            public float U_Estimatedduration { get; set; }

        }

        public class ConfirmationsCollection
        {

            public string U_Internalartisan { get; set; }
            public string U_Externalartisan { get; set; }
            public string U_Jobtype { get; set; }
            public string U_Artisan { get; set; }
            public string U_Startdate { get; set; }
            public string U_Starttime { get; set; }
            public string U_Enddate { get; set; }
            public string U_Endtime { get; set; }
            public string U_Duration { get; set; }
        }

        public class SparesusedCollection
        {

            public string U_ItemNo { get; set; }
            public string U_Description { get; set; }
            public string U_Inventory { get; set; }
            public string U_Uom { get; set; }
            public string U_Warehouse { get; set; }
            public float U_Quantity { get; set; }
            public string U_Artisan { get; set; }
        }

        public class SupervisorverifictionCollection
        {

            public string U_JobAknowledged { get; set; }
            public string U_LockOutRequired { get; set; }
            public string U_Workpermitdone { get; set; }
            public string U_Workpermitnumber { get; set; }
            public string U_Workcentre { get; set; }
        }
    }
    public class PatchWorkorderEngMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Notstatus { get; set; }
        public string U_Originator { get; set; }
        public string U_Natureofjob { get; set; }
        public string U_Description { get; set; }
        public string U_Department { get; set; }
        public string U_Plant { get; set; }
        public string U_Machine { get; set; }
        public string U_Subassemble { get; set; }
        public string U_Equipment { get; set; }
        public string U_Number { get; set; }
        public string U_Notnumber { get; set; }
        public string U_JobType { get; set; }
        public string U_FaultDate { get; set; }
        public string U_Faulttime { get; set; }
        public string U_Submissiondate { get; set; }
        public string U_Submissiontime { get; set; }
        public string U_SHEstatus { get; set; }

        public List<RequestCollection> REQUESTCollection { get; set; }
        public List<CorractiveCollection> CORRECTIVECollection { get; set; }
        public List<PreventiveCollection> PREVENTIVECollection { get; set; }
        public List<VerificationCollection> VERIFICATIONCollection { get; set; }
        public List<ArtisantaskCollection> ARTISANTASKCollection { get; set; }
        public List<SparesusedCollection> SPARESUSEDCollection { get; set; }
        public List<SupervisorverifictionCollection> SUPERVISORVERCollection { get; set; }
        public List<NotcommentsCollection> NOTCOMMENTSCollection { get; set; }
        public List<ConfirmationsCollection> CONFIRMATIONSCollection { get; set; }
        public List<SheverifyCollection> SHEQVERIFYCollection { get; set; }


        public class RequestCollection
        {
         //   public int DocEntry { get; set; }
         //   public int LineId { get; set; }
            public string U_Details { get; set; }
            public string U_Date { get; set; }
        }
        public class NotcommentsCollection
        {
           // public int DocEntry { get; set; }
          //  public int LineId { get; set; }
            public string U_Comment { get; set; }
            public string U_Date { get; set; }
        }

        public class CorractiveCollection
        {
          //  public int DocEntry { get; set; }
          //  public int LineId { get; set; }
            public string U_Corrective { get; set; }
        }

        public class PreventiveCollection
        {
       //     public int DocEntry { get; set; }
         //   public int LineId { get; set; }
            public string U_Preventive { get; set; }
        }

        public class VerificationCollection
        {
          //  public int DocEntry { get; set; }
           // public int LineId { get; set; }
            public string U_Originatorverified { get; set; }
            public string U_Originatorname { get; set; }
            public string U_Originatorhandovertime { get; set; }
            public string U_Comment { get; set; }
            public string U_Title { get; set; }
        }

        public class ArtisantaskCollection
        {
          //  public int DocEntry { get; set; }
         //   public int LineId { get; set; }
            public string U_Internalartisan { get; set; }
            public string U_Externalartisan { get; set; }
            public string U_Task { get; set; }
            public string U_Description { get; set; }
            public float U_Estimatedduration { get; set; }

        }

        public class ConfirmationsCollection
        {
          //  public int DocEntry { get; set; }
          //  public int LineId { get; set; }
            public string U_Internalartisan { get; set; }
            public string U_Externalartisan { get; set; }
            public string U_Jobtype { get; set; }
            public string U_Artisan { get; set; }
            public string U_Startdate { get; set; }
            public string U_Starttime { get; set; }
            public string U_Enddate { get; set; }
            public string U_Endtime { get; set; }
            public string U_Duration { get; set; }
        }

        public class SparesusedCollection
        {
         //   public int DocEntry { get; set; }
          //  public int LineId { get; set; }
            public string U_ItemNo { get; set; }
            public string U_Description { get; set; }
            public string U_Inventory { get; set; }
            public string U_Uom { get; set; }
            public string U_Warehouse { get; set; }
            public float U_Quantity { get; set; }
            public string U_Artisan { get; set; }
        }

        public class SupervisorverifictionCollection
        {
           // public int DocEntry { get; set; }
           // public int LineId { get; set; }
            public string U_JobAknowledged { get; set; }
            public string U_LockOutRequired { get; set; }
            public string U_Workpermitdone { get; set; }
            public string U_Workpermitnumber { get; set; }
            public string U_Workcentre { get; set; }
        }
        public class SheverifyCollection
        {
            public string U_Date { get; set; }
            public string U_Time { get; set; }
            public string U_Comment { get; set; }
            public string U_Status { get; set; }
            public string U_SheVerifier { get; set; }
        }
    }
}
