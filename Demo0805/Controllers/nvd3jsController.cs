using Demo0805.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Demo0805.Controllers
{
    public class nvd3jsController : Controller
    {
        private JJMFDBEntities db = new JJMFDBEntities();

        //
        // GET: /nvd3js/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddFun(int a,int b)
        {
            return Json(a+b);
        }
        public class AddNumber
        {
            public int a { get; set; }
            public int b { get; set; }
        }
        

        public ActionResult JJMFVis()
        {
            var jss = new System.Web.Script.Serialization.JavaScriptSerializer();
            
           

           ViewBag.xAxisLabel = jss.Serialize(xAxisLabel().Select(a => a.Label));
            return View();
        }
        public ActionResult JsonTest()
        {
            



            
            return View();
        }

        public JsonResult JJMFVisData()
        {
            var newList = xAxisLabel();
            var AxisLabelData1= (from a in db.vwEstCompareReals
                                 select new { EmpName = a.員工編號姓名, First = a.第一階作業, Time1 = a.預估時數, Time2 = a.實際時數 }).ToList();

            var AxisLabelData = (from a in AxisLabelData1
                                 join z in newList on new { Name = a.EmpName } equals new { Name = z.Label }
                                 select new { EmpName = a.EmpName, First = a.First, Time1 = a.Time1, Time2 = a.Time2, Name =z.Label,LabelID=z.LabelID}).ToList();

            var CompareData = AxisLabelData.GroupBy(g => g.First)
                                                .Select(b => new NVD3MultiChartModel
                                                {
                                                    key = b.Key,
                                                    type = "bar",
                                                    yAxis = 1,
                                                    values = b.Select(c => new values { x = c.LabelID, y = (decimal)(c.Time1 == null ? 0 : c.Time1) }).ToList()
                                                }).ToList();
          
            return Json(CompareData, JsonRequestBehavior.AllowGet);
        }

        public List<AxisLabelModel> xAxisLabel()
        {
            int i = 0;
            List<AxisLabelModel> Label = new List<AxisLabelModel>();
            foreach (var d in db.vwEstCompareReals.Select(n => n.員工編號姓名).Distinct())
            {
                Label.Add(new AxisLabelModel { Label = d, LabelID = i });
                i++;
            }

            return Label;
        }

       
    }
}