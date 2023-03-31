using System.Collections.Generic;

namespace PROPLASTICSAPI.Models.SHEQ
{
    //Promouldings Production Quality Control
    public class PROPQCMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Shift { get; set; }
        public string U_Date { get; set; }
        public string U_Status { get; set; }
        public List<ParamlinesCollection> PARAMLINESCollection { get; set; }// Main machine parameter lines
        public List<OparamlinesCollection> OPARAMLINESCollection { get; set; }// Other machine parameter lines

        public class ParamlinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_Product { get; set; }
            public string U_FOWrkmnshp { get; set; } //First-off workmanship
            public float U_ControlWeight { get; set; }
            public float U_ActualWeight { get; set; }
            public string U_Wrkmnshp { get; set; } //workmanship
            public string U_Pressure { get; set; }
            public string U_HResistance { get; set; } //Heat resistance
            public float U_SDepthA { get; set; } //socket depth A
            public float U_SDepthB { get; set; } //socket depth B
            public float U_SDepthC { get; set; } //socket depth C
            public float U_IDODA { get; set; } //ID/OD A
            public float U_IDODB { get; set; } //ID/OD B
            public float U_IDODC { get; set; } //ID/OD C
            public string U_AppStandards { get; set; } //applicable standards
        }

        public class OparamlinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_Product { get; set; }
            public float U_ControlWeight { get; set; }
            public float U_ActualWeight { get; set; }
            public string U_Wrkmnshp { get; set; } //workmanship
            public string U_AppStandards { get; set; } //applicable standards
        }
    }
    public class PostPROPQCMDL
    {
        public string U_Shift { get; set; }
        public string U_Date { get; set; }
        public string U_Status { get; set; }
        public List<ParamlinesCollection> PARAMLINESCollection { get; set; }// Main machine parameter lines
        public List<OparamlinesCollection> OPARAMLINESCollection { get; set; }// Other machine parameter lines

        public class ParamlinesCollection
        {
            public string U_Machine { get; set; }
            public string U_Product { get; set; }
            public string U_FOWrkmnshp { get; set; } //First-off workmanship
            public float U_ControlWeight { get; set; }
            public float U_ActualWeight { get; set; }
            public string U_Wrkmnshp { get; set; } //workmanship
            public string U_Pressure { get; set; }
            public string U_HResistance { get; set; } //Heat resistance
            public float U_SDepthA { get; set; } //socket depth A
            public float U_SDepthB { get; set; } //socket depth B
            public float U_SDepthC { get; set; } //socket depth C
            public float U_IDODA { get; set; } //ID/OD A
            public float U_IDODB { get; set; } //ID/OD B
            public float U_IDODC { get; set; } //ID/OD C
            public string U_AppStandards { get; set; } //applicable standards
        }

        public class OparamlinesCollection
        {
            public string U_Machine { get; set; }
            public string U_Product { get; set; }
            public float U_ControlWeight { get; set; }
            public float U_ActualWeight { get; set; }
            public string U_Wrkmnshp { get; set; } //workmanship
            public string U_AppStandards { get; set; } //applicable standards
        }
    }
    public class PatchPROPQCMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Shift { get; set; }
        public string U_Date { get; set; }
        public string U_Status { get; set; }
        public List<ParamlinesCollection> PARAMLINESCollection { get; set; }// Main machine parameter lines
        public List<OparamlinesCollection> OPARAMLINESCollection { get; set; }// Other machine parameter lines

        public class ParamlinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_Product { get; set; }
            public string U_FOWrkmnshp { get; set; } //First-off workmanship
            public float U_ControlWeight { get; set; }
            public float U_ActualWeight { get; set; }
            public string U_Wrkmnshp { get; set; } //workmanship
            public string U_Pressure { get; set; }
            public string U_HResistance { get; set; } //Heat resistance
            public float U_SDepthA { get; set; } //socket depth A
            public float U_SDepthB { get; set; } //socket depth B
            public float U_SDepthC { get; set; } //socket depth C
            public float U_IDODA { get; set; } //ID/OD A
            public float U_IDODB { get; set; } //ID/OD B
            public float U_IDODC { get; set; } //ID/OD C
            public string U_AppStandards { get; set; } //applicable standards
        }

        public class OparamlinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_Product { get; set; }
            public float U_ControlWeight { get; set; }
            public float U_ActualWeight { get; set; }
            public string U_Wrkmnshp { get; set; } //workmanship
            public string U_AppStandards { get; set; } //applicable standards
        }
    }
}