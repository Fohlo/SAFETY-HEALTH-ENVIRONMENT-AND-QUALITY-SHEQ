using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.Models.Engineering
{
    public class HarzadousWorkPermitMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Department { get; set; }
        public string U_WrkCarriedOut { get; set; }
        public string U_JobCardNo { get; set; }
        public string U_PrsnInCharge { get; set; }
        public string U_Authorized { get; set; }
        public string U_DateCompleted { get; set; }
        public string U_Date { get; set; }
        public string U_TimeCompleted { get; set; }
        public string U_Supervisor { get; set; }
        public string U_SafetyOfficer { get; set; }
        public List<HwphwlinesCollection> HWPHWLINESCollection { get; set; }// Harzadous Work Permit Hot Work Checklist
        public List<HwpcslinesCollection> HWPCSLINESCollection { get; set; }// Harzadous Work Permit Confined Space Checklist
        public List<HwphlinesCollection> HWPHLINESCollection { get; set; }// Harzadous Work Permit Heights Checklist

        public class HwphwlinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
        public class HwpcslinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
        public class HwphlinesCollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
    }
    public class PostHarzadousWorkPermitMDL
    {
        public string U_Department { get; set; }
        public string U_WrkCarriedOut { get; set; }
        public string U_JobCardNo { get; set; }
        public string U_PrsnInCharge { get; set; }
        public string U_Authorized { get; set; }
        public string U_DateCompleted { get; set; }
        public string U_Date { get; set; }
        public string U_TimeCompleted { get; set; }
        public string U_Supervisor { get; set; }
        public string U_SafetyOfficer { get; set; }
        public List<HwphwlinesCollection> HWPHWLINESCollection { get; set; }// Harzadous Work Permit Hot Work Checklist
        public List<HwpcslinesCollection> HWPCSLINESCollection { get; set; }// Harzadous Work Permit Confined Space Checklist
        public List<HwphlinesCollection> HWPHLINESCollection { get; set; }// Harzadous Work Permit Heights Checklist

        public class HwphwlinesCollection
        {
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
        public class HwpcslinesCollection
        {
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
        public class HwphlinesCollection
        {
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
    }
    public class PatchHarzadousWorkPermitMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Department { get; set; }
        public string U_WrkCarriedOut { get; set; }
        public string U_JobCardNo { get; set; }
        public string U_PrsnInCharge { get; set; }
        public string U_Authorized { get; set; }
        public string U_DateCompleted { get; set; }
        public string U_Date { get; set; }
        public string U_TimeCompleted { get; set; }
        public string U_Supervisor { get; set; }
        public string U_SafetyOfficer { get; set; }
        public List<HwphwlinesCollection> HWPHWLINESCollection { get; set; }// Harzadous Work Permit Hot Work Checklist
        public List<HwpcslinesCollection> HWPCSLINESCollection { get; set; }// Harzadous Work Permit Confined Space Checklist
        public List<HwphlinesCollection> HWPHLINESCollection { get; set; }// Harzadous Work Permit Heights Checklist

        public class HwphwlinesCollection
        {
          //  public int DocEntry { get; set; }
         //   public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
        public class HwpcslinesCollection
        {
          //  public int DocEntry { get; set; }
          //  public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
        public class HwphlinesCollection
        {
          //  public int DocEntry { get; set; }
         //   public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_IsChecked { get; set; }
        }
    }

}


