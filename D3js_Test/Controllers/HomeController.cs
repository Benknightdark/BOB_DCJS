using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace D3js_Test.Controllers
{
    public class HomeController : Controller
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult test()
        {
            return View();
        }
        [HttpPost]
        public JsonResult getdata()
        {
            WebRequest request = WebRequest.Create("http://jjmf.azurewebsites.net/api/avms/201507");
            return Json(request, JsonRequestBehavior.AllowGet);
        }
    }
}