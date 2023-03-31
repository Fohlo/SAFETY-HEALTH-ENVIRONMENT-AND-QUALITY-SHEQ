using System.Collections.Generic;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class PVCMDL
    {
        public int DocNum { get; set; }
        public string U_Status { get; set; }
        public string U_Remarks { get; set; }
        public string U_QCName { get; set; }
        public string U_QCSign { get; set; }
        public List<PVClinescollection> PVCLINESCollection { get; set; }

        public class PVClinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_ProductDescription { get; set; }
            public string U_JobNo { get; set; }
            public string U_Class { get; set; }
            public string U_OD { get; set; }
            public string U_ID { get; set; }
            public float U_Length { get; set; }
            public float U_Thread { get; set; }
            public float U_Angles { get; set; }
            public string U_Squareness { get; set; }
            public string U_SolventCement { get; set; }
            public string U_SparkTesting { get; set; }
            public string U_Sockets { get; set; }
            public string U_Chamfer { get; set; }
            public string U_ProductLabelling { get; set; }
            public string U_FactoryCheck { get; set; }
            public string U_Workmanship { get; set; }
            public float U_Target { get; set; }
            public float U_Actual { get; set; }
            public float U_TestDone { get; set; }
        }
    }
    public class PostPVCMDL
    {
        public string U_Status { get; set; }
        public string U_Remarks { get; set; }
        public string U_QCName { get; set; }
        public string U_QCSign { get; set; }
        public List<PVClinescollection> PVCLINESCollection { get; set; }

        public class PVClinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_ProductDescription { get; set; }
            public string U_JobNo { get; set; }
            public string U_Class { get; set; }
            public string U_OD { get; set; }
            public string U_ID { get; set; }
            public float U_Length { get; set; }
            public float U_Thread { get; set; }
            public float U_Angles { get; set; }
            public string U_Squareness { get; set; }
            public string U_SolventCement { get; set; }
            public string U_SparkTesting { get; set; }
            public string U_Sockets { get; set; }
            public string U_Chamfer { get; set; }
            public string U_ProductLabelling { get; set; }
            public string U_FactoryCheck { get; set; }
            public string U_Workmanship { get; set; }
            public float U_Target { get; set; }
            public float U_Actual { get; set; }
            public float U_TestDone { get; set; }
        }
    }
    public class PatchPVCMDL
    {
        public string U_Status { get; set; }
        public string U_Remarks { get; set; }
        public string U_QCName { get; set; }
        public string U_QCSign { get; set; }
        public List<PVClinescollection> PVCLINESCollection { get; set; }

        public class PVClinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_ProductDescription { get; set; }
            public string U_JobNo { get; set; }
            public string U_Class { get; set; }
            public string U_OD { get; set; }
            public string U_ID { get; set; }
            public float U_Length { get; set; }
            public float U_Thread { get; set; }
            public float U_Angles { get; set; }
            public string U_Squareness { get; set; }
            public string U_SolventCement { get; set; }
            public string U_SparkTesting { get; set; }
            public string U_Sockets { get; set; }
            public string U_Chamfer { get; set; }
            public string U_ProductLabelling { get; set; }
            public string U_FactoryCheck { get; set; }
            public string U_Workmanship { get; set; }
            public float U_Target { get; set; }
            public float U_Actual { get; set; }
            public float U_TestDone { get; set; }
        }
    }
}