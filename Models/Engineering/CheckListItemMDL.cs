using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.Models.Engineering
{
    public class CheckListItemMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Type { get; set; }
        public string U_Name { get; set; }
        public List<Clilcollection> CLILCollection { get; set; }

        public class Clilcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Item { get; set; }
        }


    }
    public class PostCheckListItemMDL
    {
       // public int DocNum { get; set; }
      //  public int DocEntry { get; set; }
        public string U_Type { get; set; }
        public string U_Name { get; set; }
        public List<Clilcollection> CLILCollection { get; set; }

        public class Clilcollection
        {
         //   public string U_Detail { get; set; }
          //  public string U_Days { get; set; }
            public string U_Item { get; set; }
        }


    }
}