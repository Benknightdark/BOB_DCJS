using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo0805.Models;
using Newtonsoft.Json.Linq;
namespace Demo0805.Controllers
{
    public class d3jsController : BaseController
    {
        private BOBEntities db = new BOBEntities();
        public ActionResult Treemap()
        {

            var orders = db.orders;
            var bookstore = db.bookstores;
            var books = db.books;
            var city_count = db.bookstores.Distinct().Select(a => a.city).ToList();
            
            #region test
            //List<object> city = new List<object>();
            //List<object> name = new List<object>();
            //List<object> publisher = new List<object>();
            //List<object> book = new List<object>();
           
            //foreach (var a in city_count)//root_name
            //{
            //    var bookstore_count = db.bookstores.Where(c => c.city == a).Select(b => b.name).ToList();
               
            //    foreach (var d in bookstore_count)//child1_name
            //    {
            //        name.Add(new   { name = d.Trim() });
            //        //var publisher_count = db.orders.Where(c => c.bookstore.name == d).Select(b => b.book.publisher).ToList();
            //       // foreach (var e in publisher_count)//child2_name
            //       // {                     
            //       //     publisher.Add(new { name = e.Trim() });
            //       //     var book_count = db.orders.Where(c => c.book.publisher == e).Select(b => new { b.book.bookname, b.quantity }).ToList();
            //       //     book.Clear();
            //       //     //foreach (var f in book_count)///leaf
            //       //     //{
            //       //     //    //book.Add(new { name = f.bookname, size = f.quantity });
                            
            //       //     //}
            //       ////     publisher.AddRange(book);
            //       //   //  book.Clear();
                      
            //       // }
            //    }

            //    city.Add(new { name = a.Trim() });

            //    //name.AddRange(publisher);
            //    city.AddRange(name);
            //    name.Clear();
            //    //book.Clear();

            //}

            //ViewBag.list =JsonConvert.SerializeObject( city);
            #endregion

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
        public ActionResult Index()
        {
            return View();
        }
    }

}

public class TreeMap
{
    public string name { set; get; }//姓名
    public List<object>  children { set; get; }//姓名
}