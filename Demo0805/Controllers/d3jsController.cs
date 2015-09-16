using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo0805.Models;
using Newtonsoft.Json;
namespace Demo0805.Controllers
{
    public class d3jsController : BaseController
    {
      private   BOBEntities db = new BOBEntities();
      public ActionResult Treemap()
      {
          return View();
      }
        //
        // GET: /d3js/
        [HttpPost]
        public JsonResult Bookstores()
        {
            var bookstores = from a in db.bookstores
                             select  new d3js.BookstoresGraph { name = a.name,city=a.city, rank=a.rank };
            return Json(bookstores.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Orders()
        {
            var Orders = (from a in db.orders
                          join b in db.books on a.id equals b.id
                          join c in db.bookstores on a.no equals c.no
                          orderby a.quantity descending
                          select new BOBOrderList.OrderList { name = c.name.Trim(), bookname = b.bookname.Trim(), quantity = a.quantity,publisher=b.publisher,  id = a.id, no = a.no });
            return Json(Orders.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
	}
  
}