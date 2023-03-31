using System.Collections.Generic;

namespace PROPLASTICSAPI.Models.SHEQ
{
    public class SARMDL
    {
        public int? DocNum { get; set; }
        public string U_Status { get; set; }
        public string U_DateReceived { get; set; }
        public string U_DateTested { get; set; }
        public string U_ProductType { get; set; }
        public string U_Manufacturer { get; set; }
        public string U_BatchNumber { get; set; }
        public string U_Countryoforigin { get; set; }
        public string U_Conclusion { get; set; }
        public string U_DensityComment { get; set; }
        public string U_MoistureComment { get; set; }
        public List<TestLinescollection> TESTLINEScollections { get; set; }
        public List<PropertyLinescollection> PROPERTLINEScollections { get; set; }
        public List<BulkyDensityTestLinescollection> BULKYDENSITYTESTLINEScollections { get; set; }
        public List<MoistureContentTestLinescollection> MOISTURECONTENTTESTLINEScollections { get; set; }

        public class TestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_TestNumber { get; set; }
            public float U_W1 { get; set; }
            public float U_W2 { get; set; }
            public float U_W1W2initial { get; set; }
            public float U_W3 { get; set; }
            public float U_W3W1initial { get; set; }
            public float U_W4 { get; set; }
            public float U_W4W1intitial { get; set; }
            public float U_Mean { get; set; }

        }
        public class PropertyLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Property { get; set; }
            public float U_Controlvalue { get; set; }
            public float U_Valueobtained { get; set; }
            public string U_Comment { get; set; }
            public string U_TestMethod { get; set; }
        }
        public class BulkyDensityTestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_A { get; set; }
            public float U_V { get; set; }
            public float U_C { get; set; }
            public float U_M { get; set; }
            public float U_BulkyDensity { get; set; }
            public float U_Kvalue { get; set; }
        }
        public class MoistureContentTestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_Massofbeaker { get; set; }
            public float U_Massofmaterial { get; set; }
            public float U_BeakeraddMaterial { get; set; }
            public float U_Moisturecontent { get; set; }
            public float U_Percentagemoisturecontent { get; set; }
            public float U_Controlvalue { get; set; }
        }
    }
    public class PostSARMDL
    {
        public string U_Status { get; set; }
        public string U_DateReceived { get; set; }
        public string U_DateTested { get; set; }
        public string U_ProductType { get; set; }
        public string U_Manufacturer { get; set; }
        public string U_BatchNumber { get; set; }
        public string U_Countryoforigin { get; set; }
        public string U_Conclusion { get; set; }
        public string U_DensityComment { get; set; }
        public string U_MoistureComment { get; set; }
        public List<TestLinescollection> TESTLINEScollections { get; set; }
        public List<PropertyLinescollection> PROPERTLINEScollections { get; set; }
        public List<BulkyDensityTestLinescollection> BULKYDENSITYTESTLINEScollections { get; set; }
        public List<MoistureContentTestLinescollection> MOISTURECONTENTTESTLINEScollections { get; set; }

        public class TestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_TestNumber { get; set; }
            public float U_W1 { get; set; }
            public float U_W2 { get; set; }
            public float U_W1W2initial { get; set; }
            public float U_W3 { get; set; }
            public float U_W3W1initial { get; set; }
            public float U_W4 { get; set; }
            public float U_W4W1intitial { get; set; }
            public float U_Mean { get; set; }

        }
        public class PropertyLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Property { get; set; }
            public float U_Controlvalue { get; set; }
            public float U_Valueobtained { get; set; }
            public string U_Comment { get; set; }
            public string U_TestMethod { get; set; }
        }
        public class BulkyDensityTestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_A { get; set; }
            public float U_V { get; set; }
            public float U_C { get; set; }
            public float U_M { get; set; }
            public float U_BulkyDensity { get; set; }
            public float U_Kvalue { get; set; }
        }
        public class MoistureContentTestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_Massofbeaker { get; set; }
            public float U_Massofmaterial { get; set; }
            public float U_BeakeraddMaterial { get; set; }
            public float U_Moisturecontent { get; set; }
            public float U_Percentagemoisturecontent { get; set; }
            public float U_Controlvalue { get; set; }
        }
    }
    public class PatchSARMDL
    {
        public string U_Status { get; set; }
        public string U_DateReceived { get; set; }
        public string U_DateTested { get; set; }
        public string U_ProductType { get; set; }
        public string U_Manufacturer { get; set; }
        public string U_BatchNumber { get; set; }
        public string U_Countryoforigin { get; set; }
        public string U_Conclusion { get; set; }
        public string U_DensityComment { get; set; }
        public string U_MoistureComment { get; set; }
        public List<TestLinescollection> TESTLINEScollections { get; set; }
        public List<PropertyLinescollection> PROPERTLINEScollections { get; set; }
        public List<BulkyDensityTestLinescollection> BULKYDENSITYTESTLINEScollections { get; set; }
        public List<MoistureContentTestLinescollection> MOISTURECONTENTTESTLINEScollections { get; set; }

        public class TestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_TestNumber { get; set; }
            public float U_W1 { get; set; }
            public float U_W2 { get; set; }
            public float U_W1W2initial { get; set; }
            public float U_W3 { get; set; }
            public float U_W3W1initial { get; set; }
            public float U_W4 { get; set; }
            public float U_W4W1intitial { get; set; }
            public float U_Mean { get; set; }

        }
        public class PropertyLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public string U_Property { get; set; }
            public float U_Controlvalue { get; set; }
            public float U_Valueobtained { get; set; }
            public string U_Comment { get; set; }
            public string U_TestMethod { get; set; }
        }
        public class BulkyDensityTestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_A { get; set; }
            public float U_V { get; set; }
            public float U_C { get; set; }
            public float U_M { get; set; }
            public float U_BulkyDensity { get; set; }
            public float U_Kvalue { get; set; }
        }
        public class MoistureContentTestLinescollection
        {
            public int? DocEntry { get; set; }
            public int? LineId { get; set; }
            public float U_Massofbeaker { get; set; }
            public float U_Massofmaterial { get; set; }
            public float U_BeakeraddMaterial { get; set; }
            public float U_Moisturecontent { get; set; }
            public float U_Percentagemoisturecontent { get; set; }
            public float U_Controlvalue { get; set; }
        }
    }
}