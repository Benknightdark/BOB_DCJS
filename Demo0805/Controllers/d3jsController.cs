using Demo0805.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Demo0805.Controllers
{
    public class d3jsController : BaseController
    {
        private BOBEntities db = new BOBEntities();

        public ActionResult Treemap()
        {
            var bookstore = db.bookstores;
            var books = db.books;
            var orders = db.orders;

            return View(orders.ToList());
        }

        //
        // GET: /d3js/
        [HttpPost]
        public JsonResult Bookstores()
        {
            var bookstores = from a in db.bookstores
                             select new d3js.BookstoresGraph { name = a.name, city = a.city, rank = a.rank };
            return Json(bookstores.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Orders()
        {
            var Orders = (from a in db.orders
                          join b in db.books on a.id equals b.id
                          join c in db.bookstores on a.no equals c.no
                          orderby c.name descending
                          select new BOBOrderList.OrderList { name = c.name.Trim(), bookname = b.bookname.Trim(), quantity = a.quantity, publisher = b.publisher, id = a.id, no = a.no });
            return Json(Orders.ToList(), JsonRequestBehavior.AllowGet);
        }

        // [HttpPost]
        public JsonResult TreeMapData()
        {
            var orders = db.orders;
            List<Object> bigroot = new List<Object>();
            List<Object> root = new List<Object>();
            List<Object> child = new List<Object>();
            var q = (from a in orders
                     group a by a.bookstore.name into g
                     select g
                   );

            foreach (var a in q)
            {
                foreach (order o in a)
                {
                    child.Add(new { name = o.book.bookname.Trim(), size = o.quantity });
                }
                root.Add(new { name = a.Key.Trim(), children = child.ToList() });
                child.Clear();
            }

            bigroot.Add(new { name = "bob", children = root.ToList() });
            return Json(bigroot, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}