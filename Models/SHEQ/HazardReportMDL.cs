using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class HazardReportMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_NatureOfHazard { get; set; }
        public string U_HazardDate{ get; set; }
        public string U_HazardLocation{ get; set; }
        public string U_Department{ get; set; }
        public string U_HazardImage{ get; set; }
        public string U_HazardDescr{ get; set; }
        public string U_PossibleCons{ get; set; }
        public string U_RequireNotCom{ get; set; }
        public string U_AccidentsCalled{ get; set; }
        public string U_PossibleSol{ get; set; }
        public List<EquipmentusedCollection> HZDEQUIPCollection { get; set; }
        public List<ToolsusedCollection> HZDTOOLSCollection { get; set; }
        public List<PersonsinvolvedCollection> HZDPERSONSCollection { get; set; }
        public List<SupervisorSectionCollection> HZDSUPCLLCollection { get; set; }
        public List<SheqSectionCollection> HZDSHEQCLLCollection { get; set; }

        public class EquipmentusedCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Equipment { get; set; }
        }
        public class ToolsusedCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Tool { get; set; }
        }
        public class PersonsinvolvedCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Person { get; set; }
        }
        public class SupervisorSectionCollection
        {
            public string U_ResultsOfInvest { get; set; }
            public string U_Signature { get; set; }
            public string U_Date { get; set; }
            public string U_PreventiveA { get; set; }
            public string U_RootCauses { get; set; }
            public string U_Action { get; set; }
            public string U_ActionR { get; set; }
            public string U_ActionCD { get; set; }
            public string U_SupName { get; set; }
        }

        public class SheqSectionCollection
        {
            public string U_Department { get; set; }
            public string U_FollowUpR { get; set; }
            public string U_Name { get; set; }
            public string U_Signature { get; set; }
            public string U_Date { get; set; }
        }
    }
    public class PostHazardReportMDL
    {
        public string U_Date { get; set; }
        public string U_NatureOfHazard { get; set; }
        public string U_HazardDate { get; set; }
        public string U_HazardLocation { get; set; }
        public string U_Department { get; set; }
        public string U_HazardImage { get; set; }
        public string U_HazardDescr { get; set; }
        public string U_PossibleCons { get; set; }
        public string U_RequireNotCom { get; set; }
        public string U_AccidentsCalled { get; set; }
        public string U_PossibleSol { get; set; }
        public List<EquipmentusedCollection> HZDEQUIPCollection { get; set; }
        public List<ToolsusedCollection> HZDTOOLSCollection { get; set; }
        public List<PersonsinvolvedCollection> HZDPERSONSCollection { get; set; }

        public class EquipmentusedCollection
        {
            public string U_Equipment { get; set; }
        }
        public class ToolsusedCollection
        {
            public string U_Tool { get; set; }
        }
        public class PersonsinvolvedCollection
        {
            public string U_Person { get; set; }
        }
    }
    public class PatchHazardReportMDL
    {
        
        public string U_Date { get; set; }
        public string U_NatureOfHazard { get; set; }
        public string U_HazardDate { get; set; }
        public string U_HazardLocation { get; set; }
        public string U_Department { get; set; }
        public string U_HazardImage { get; set; }
        public string U_HazardDescr { get; set; }
        public string U_PossibleCons { get; set; }
        public string U_RequireNotCom { get; set; }
        public string U_AccidentsCalled { get; set; }
        public string U_PossibleSol { get; set; }
        public List<EquipmentusedCollection> HZDEQUIPCollection { get; set; }
        public List<ToolsusedCollection> HZDTOOLSCollection { get; set; }
        public List<PersonsinvolvedCollection> HZDPERSONSCollection { get; set; }
        public List<SupervisorSectionCollection> HZDSUPCLLCollection { get; set; }
        public List<SheqSectionCollection> HZDSHEQCLLCollection { get; set; }


        public class EquipmentusedCollection
        {
            
            public string U_Equipment { get; set; }
        }
        public class ToolsusedCollection
        {
            
            public string U_Tool { get; set; }
        }
        public class PersonsinvolvedCollection
        {
          
            public string U_Person { get; set; }
        }

        public class SupervisorSectionCollection
        {
            public string U_ResultsOfInvest { get; set; }
            public string U_Signature { get; set; }
            public string U_Date { get; set; }
            public string U_PreventiveA { get; set; }
            public string U_RootCauses { get; set; }
            public string U_Action { get; set; }
            public string U_ActionR { get; set; }
            public string U_ActionCD { get; set; }
            public string U_SupName { get; set; }
        }

        public class SheqSectionCollection
        {
            public string U_Department { get; set; }
            public string U_FollowUpR { get; set; }
            public string U_Name { get; set; }
            public string U_Signature { get; set; }
            public string U_Date { get; set; }
        }
    }
}
