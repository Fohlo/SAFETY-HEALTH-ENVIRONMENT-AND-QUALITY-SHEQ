using System.Collections.Generic;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class PPQMDL
    {
        public int? DocNum { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Remarks { get; set; }
        public string U_QCName { get; set; }
        public string QCSign { get; set; }

        public List<PPQLinescollection> PPQLINESCollection { get; set; }

        public class PPQLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_JobNo { get; set; }
            public string U_Product { get; set; }
            public float U_STDMax { get; set; }
            public float U_STDMin { get; set; }
            public float U_STDTolerance { get; set; }
            public float U_WallthicknessMax { get; set; }
            public float U_WallthicknessMin { get; set; }
            public float U_WallthicknessTolerence { get; set; }
            public float U_ODMax { get; set; }
            public float U_ODMin { get; set; }
            public float U_ODMean { get; set; }
            public float U_Ovality { get; set; }
            public string U_ThermalReversion { get; set; }
            public string U_Highspeedimpact { get; set; }
            public string U_Pressure { get; set; }
            public string U_Workmanship { get; set; }
            public string U_Length { get; set; }
            public string U_Printing { get; set; }
            public string U_Colour { get; set; }
            public string U_Chamfer { get; set; }
            public float U_SocketDepth { get; set; }
            public float U_ColarDepth { get; set; }
            public float U_SOCIDMax { get; set; }
            public float U_SOCIDMin { get; set; }
            public float U_SOCIDOvality { get; set; }
            public string U_Lyingringsitting { get; set; }
        }
    }
    public class PatchPPQMDL
    {
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Remarks { get; set; }
        public string U_QCName { get; set; }
        public string QCSign { get; set; }
        public List<PPQLinescollection> PPQLINESCollection { get; set; }

        public class PPQLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_JobNo { get; set; }
            public string U_Product { get; set; }
            public float U_STDMax { get; set; }
            public float U_STDMin { get; set; }
            public float U_STDTolerance { get; set; }
            public float U_WallthicknessMax { get; set; }
            public float U_WallthicknessMin { get; set; }
            public float U_WallthicknessTolerence { get; set; }
            public float U_ODMax { get; set; }
            public float U_ODMin { get; set; }
            public float U_ODMean { get; set; }
            public float U_Ovality { get; set; }
            public string U_ThermalReversion { get; set; }
            public string U_Highspeedimpact { get; set; }
            public string U_Pressure { get; set; }
            public string U_Workmanship { get; set; }
            public string U_Length { get; set; }
            public string U_Printing { get; set; }
            public string U_Colour { get; set; }
            public string U_Chamfer { get; set; }
            public float U_SocketDepth { get; set; }
            public float U_ColarDepth { get; set; }
            public float U_SOCIDMax { get; set; }
            public float U_SOCIDMin { get; set; }
            public float U_SOCIDOvality { get; set; }
            public string U_Lyingringsitting { get; set; }
        }
    }
    public class PostPPQMDL
    {
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Remarks { get; set; }
        public string U_QCName { get; set; }
        public string QCSign { get; set; }
        public List<PPQLinescollection> PPQLINESCollection { get; set; }

        public class PPQLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Machine { get; set; }
            public string U_JobNo { get; set; }
            public string U_Product { get; set; }
            public float U_STDMax { get; set; }
            public float U_STDMin { get; set; }
            public float U_STDTolerance { get; set; }
            public float U_WallthicknessMax { get; set; }
            public float U_WallthicknessMin { get; set; }
            public float U_WallthicknessTolerence { get; set; }
            public float U_ODMax { get; set; }
            public float U_ODMin { get; set; }
            public float U_ODMean { get; set; }
            public float U_Ovality { get; set; }
            public string U_ThermalReversion { get; set; }
            public string U_Highspeedimpact { get; set; }
            public string U_Pressure { get; set; }
            public string U_Workmanship { get; set; }
            public string U_Length { get; set; }
            public string U_Printing { get; set; }
            public string U_Colour { get; set; }
            public string U_Chamfer { get; set; }
            public float U_SocketDepth { get; set; }
            public float U_ColarDepth { get; set; }
            public float U_SOCIDMax { get; set; }
            public float U_SOCIDMin { get; set; }
            public float U_SOCIDOvality { get; set; }
            public string U_Lyingringsitting { get; set; }
        }
    }

}