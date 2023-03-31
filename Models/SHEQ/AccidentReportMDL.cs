using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class AccidentReportMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_NatureOfInd { get; set; }
        public string U_FirstName { get; set; }
        public string U_LastName { get; set; }
        public string U_Department { get; set; }
        public string U_JobExperience { get; set; }
        public string U_Period { get; set; }
        public string U_DateOfBirth { get; set; }
        public string U_Gender { get; set; }
        public string U_Position { get; set; }
        public string U_IncidentDate { get; set; }
        public string U_IncidentLocation { get; set; }
        public string U_IncidentDescr { get; set; }
        public string U_TaskPerformed { get; set; }
        public string U_IncidentImage { get; set; }
        public string U_IncidentType { get; set; }
        public string U_IncidentTreat { get; set; }
        public string U_IncidentSeverity { get; set; }
        public string U_IntReocChance { get; set; }
        public List<EquipmentusedCollection> ACCEQUIPCollection { get; set; }
        public List<ToolsusedCollection> ACCTOOLSCollection { get; set; }
        public List<PersonsinvolvedCollection> ACCPERSONSCollection { get; set; }
        public List<InjuredpartsCollection> ACCINJUREDCollection { get; set; }
        public List<SupervisorSectionCollection> ACCSUPCLLCollection { get; set; }
        public List<SheqSectionCollection> ACCSECCollection { get; set; }


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
        public class InjuredpartsCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_InjuredPart { get; set; }
        }
        public class SupervisorSectionCollection
        {
            public string U_ResultsOfInvest { get; set; }
            public string U_Signature { get; set; }
            public string U_Date { get; set; }
            public string U_HadSimilarInjury { get; set; }
            public string U_RootCauses { get; set; }
            public string U_PropertyDD { get; set; }
            public string U_ApproxDC { get; set; }
            public string U_CorrectiveA { get; set; }
            public string U_Action { get; set; }
            public string U_ActionR { get; set; }
            public string U_ActionCD { get; set; }
            public string U_SupName { get; set; }
            public string U_ExternalR { get; set; }
            public string U_ExternalRD { get; set; }
            public string U_AccidentIn { get; set; }
            public string U_AccidentInS { get; set; }
            public string U_AccidentInD { get; set; }
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
    public class PostAccidentReportMDL
    {
        public string U_Date { get; set; }
        public string U_NatureOfInd { get; set; }
        public string U_FirstName { get; set; }
        public string U_LastName { get; set; }
        public string U_Department { get; set; }
        public string U_JobExperience { get; set; }
        public string U_Period { get; set; }
        public string U_DateOfBirth { get; set; }
        public string U_Gender { get; set; }
        public string U_Position { get; set; }
        public string U_IncidentDate { get; set; }
        public string U_IncidentLocation { get; set; }
        public string U_IncidentDescr { get; set; }
        public string U_TaskPerformed { get; set; }
        public string U_IncidentImage { get; set; }
        public string U_IncidentType { get; set; }
        public string U_IncidentTreat { get; set; }
        public string U_IncidentSeverity { get; set; }
        public string U_IntReocChance { get; set; }
        public List<EquipmentusedCollection> ACCEQUIPCollection { get; set; }
        public List<ToolsusedCollection> ACCTOOLSCollection { get; set; }
        public List<PersonsinvolvedCollection> ACCPERSONSCollection { get; set; }
        public List<InjuredpartsCollection> ACCINJUREDCollection { get; set; }

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
        public class InjuredpartsCollection
        {
            public string U_InjuredPart { get; set; }
        }
    }
    public class PatchAccidentReportMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_NatureOfInd { get; set; }
        public string U_FirstName { get; set; }
        public string U_LastName { get; set; }
        public string U_Department { get; set; }
        public string U_JobExperience { get; set; }
        public string U_Period { get; set; }
        public string U_DateOfBirth { get; set; }
        public string U_Gender { get; set; }
        public string U_Position { get; set; }
        public string U_IncidentDate { get; set; }
        public string U_IncidentLocation { get; set; }
        public string U_IncidentDescr { get; set; }
        public string U_TaskPerformed { get; set; }
        public string U_IncidentImage { get; set; }
        public string U_IncidentType { get; set; }
        public string U_IncidentTreat { get; set; }
        public string U_IncidentSeverity { get; set; }
        public string U_IntReocChance { get; set; }
        public List<EquipmentusedCollection> ACCEQUIPCollection { get; set; }
        public List<ToolsusedCollection> ACCTOOLSCollection { get; set; }
        public List<PersonsinvolvedCollection> ACCPERSONSCollection { get; set; }
        public List<InjuredpartsCollection> ACCINJUREDCollection { get; set; }
        public List<SupervisorSectionCollection> ACCSUPCLLCollection { get; set; }
        public List<SheqSectionCollection> ACCSECCollection { get; set; }

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
        public class InjuredpartsCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_InjuredPart { get; set; }
        }
        public class SupervisorSectionCollection
        {
            public string U_ResultsOfInvest { get; set; }
            public string U_Signature { get; set; }
            public string U_Date { get; set; }
            public string U_HadSimilarInjury { get; set; }
            public string U_RootCauses { get; set; }
            public string U_PropertyDD { get; set; }
            public string U_ApproxDC { get; set; }
            public string U_CorrectiveA { get; set; }
            public string U_Action { get; set; }
            public string U_ActionR { get; set; }
            public string U_ActionCD { get; set; }
            public string U_SupName { get; set; }
            public string U_ExternalR { get; set; }
            public string U_ExternalRD { get; set; }
            public string U_AccidentIn { get; set; }
            public string U_AccidentInS { get; set; }
            public string U_AccidentInD { get; set; }
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
