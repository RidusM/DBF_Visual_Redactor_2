using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF_Visual_Redactor.DataClasses
{
    public class WarehousData
    {
            public string ID { get; set; }
            public string ID_PRCG { get; set; }
            public string NAME { get; set; }
            public string FOLDER { get; set; }
            public decimal WEIGHT { get; set; }
            public decimal INPACK { get; set; }
            public decimal QTY { get; set; }
            public decimal COST1 { get; set; }
    }
}
