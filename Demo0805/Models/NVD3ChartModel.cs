using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo0805.Models
{
    
    public class NVD3MultiChartModel
    {
        public string key { get; set; }
        public string type { get; set; }
        public IList<values> values { get; set; }
        public int yAxis { get;set; }
    }
   public  partial  class values
    {
       public decimal x { get; set; }
       public decimal y { get; set; }
    }
   public class AxisLabelModel
   {
       public string Label { get; set; }
       public int LabelID { get; set; }
   }
}