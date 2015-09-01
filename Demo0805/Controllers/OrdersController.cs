using Demo0805.Helpers;
using Demo0805.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Demo0805.Controllers
{
    public class OrdersController : BaseController
    {
        private BOBEntities BOB = new BOBEntities();
        private List<SelectListItem> Bookitems = new List<SelectListItem>();
        private List<SelectListItem> BookStoreStoreitems = new List<SelectListItem>();

        //
        // GET: /Orders/
        public ActionResult Index()
        {
            ViewBag.Title = "Orders Data";

            var Orders = (from a in BOB.orders
                          join b in BOB.books on a.id equals b.id
                          join c in BOB.bookstores on a.no equals c.no
                          orderby a.quantity descending
                          select new BOBOrderList.OrderList { name = c.name, bookname = b.bookname, quantity = a.quantity, id = a.id, no = a.no });
            BookStoresList();
            BooksList();
            return View(Orders.ToList());
        }

        public ActionResult BookSelected(long id)
        {
            ViewBag.Title = "BookSelected Data";
            var bookstoreselected = (
                                    from a in BOB.orders
                                    join b in BOB.books on a.id equals b.id
                                    join c in BOB.bookstores on a.no equals c.no
                                    where b.id == id
                                    orderby a.quantity descending
                                    select new BOBOrderList.OrderList { name = c.name, bookname = b.bookname, quantity = a.quantity, id = a.id, no = a.no }
                                     );
            if (bookstoreselected != null)
            {
                return View(bookstoreselected.ToList());
            }
            else
            {
                return Content("no data");
            }
        }

        

        public ActionResult BookStoreSelected(long no)
        {
            ViewBag.Title = "BookStoreSelected Data";
            var bookstoreselected = (from a in BOB.orders
                                     join b in BOB.books on a.id equals b.id
                                     join c in BOB.bookstores on a.no equals c.no
                                     where c.no == no
                                     orderby a.quantity descending
                                     select new BOBOrderList.OrderList { name = c.name, bookname = b.bookname, quantity = a.quantity, id = a.id, no = a.no });
            if (bookstoreselected != null)
            {
                return View(bookstoreselected.ToList());
            }
            else
            {
                return Content("no data");
            }
        }

        public ActionResult Edit(long? no, long? id)
        {
            ViewBag.Title = "Edit Data";
            if ((no == null && id == null) || no == null || id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Orders_Edit = (from a in BOB.orders
                               join b in BOB.books on a.id equals b.id
                               join c in BOB.bookstores on a.no equals c.no
                               where c.no == no && b.id == id
                               orderby a.quantity descending
                               select new BOBOrderList.OrderList { name = c.name, bookname = b.bookname, quantity = a.quantity, id = a.id, no = a.no });
            if (Orders_Edit == null)
            {
                return HttpNotFound();
            }

            return View(Orders_Edit);
        }

        [HttpPost]
        public ActionResult Edit(long no, long id, FormCollection fc)
        {
            var orders = BOB.orders.Where(z => z.id == id && z.no == no);
            var quantity = int.Parse(fc["item.quantity"].ToString());
            if (orders != null)
            {
                foreach (order ord in orders)
                {
                    ord.quantity = quantity;
                }

                try
                {
                    BOB.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    return Content(e.ToString());
                    // Provide for exceptions.
                }
            }
            return View();
        }

        public ActionResult Delete(long? no, long? id)
        {
            ViewBag.Title = "Delete Data";

            var bookstoreselected = (
                                    from a in BOB.orders
                                    join b in BOB.books on a.id equals b.id
                                    join c in BOB.bookstores on a.no equals c.no
                                    where b.id == id && c.no == no
                                    orderby a.quantity descending
                                    select new BOBOrderList.OrderList { name = c.name, bookname = b.bookname, quantity = a.quantity, id = a.id, no = a.no }
                                     );

            if (bookstoreselected != null)
            {
                return View(bookstoreselected.ToList());
            }
            else
            {
                return Content("no data");
            }
        }

        [HttpPost]
        public ActionResult Delete(long no, long id)
        {
            var orders = BOB.orders.Where(z => z.id == id && z.no == no);
            if (orders != null)
            {
                foreach (var ord in orders)
                {
                    BOB.orders.Remove(ord);
                }
                try
                {
                    BOB.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    return Content(e.ToString());
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            long id = int.Parse(fc["BooksList"].ToString());
            long no = int.Parse(fc["BookStoresList"].ToString());
            int quantity = int.Parse(fc["quantity"].ToString());
            if (datacheck(id, no) == true)
            {
                order order = new order();
                order.id = id;
                order.no = no;
                order.quantity = quantity;
                BOB.orders.Add(order);
                BOB.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Content("資料不可重複輸入");
            }
        }


        #region function

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                BOB.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// 判斷是否有重複存貨資料
        /// </summary>
        /// <param name="id"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        public bool datacheck(long id, long no)
        {
            bool isavailable = true;
            if (BOB.orders.Any(z => z.id == id && z.no == no) == true)
            {
                isavailable = false;
            }
            return (isavailable);
        }

        #endregion function

        #region 下拉式選單

        /// <summary>
        /// 書店資料下拉單
        /// </summary>

        public void BookStoresList()
        {
            var BookStoresList = BOB.bookstores.Select(r => new { r.name, r.no });

            foreach (var t in BookStoresList)
            {
                SelectListItem bs = new SelectListItem();
                bs.Text = t.name.ToString();
                bs.Value = t.no.ToString();
                BookStoreStoreitems.Add(bs);
            }
            ViewBag.BookStoresList = BookStoreStoreitems;
        }

        /// <summary>
        /// 書籍資料下拉單
        /// </summary>
        public void BooksList()
        {
            var BooksList = BOB.books.Select(r => new { r.bookname, r.id });

            foreach (var t in BooksList)
            {
                SelectListItem b = new SelectListItem();
                b.Text = t.bookname.ToString();
                b.Value = t.id.ToString();
                Bookitems.Add(b);
            }
            ViewBag.BooksList = Bookitems;
        }
    }

        #endregion 下拉式選單
}