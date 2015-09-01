using Demo0805.Helpers;
using Demo0805.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Demo0805.Controllers
{
    public class BookstoresController : BaseController
    {
        private BOBEntities BOB = new BOBEntities();

        /// <summary>
        /// 新增書局資料頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            ViewBag.Title = "create data";
            return View();
        }

        /// <summary>
        /// 新增書局資料功能
        /// </summary>
        /// <param name="bookstore"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(bookstore bookstore)
        {
            bool IsAvailable = false;
            if (ModelState.IsValid)//判斷valiation的驗證是否通過
            {
                IsAvailable = datacheck(ModelState, bookstore,1);
                if (IsAvailable == true)
                {
                    BOB.bookstores.Add(bookstore);
                    BOB.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    
                    return RedirectToAction("error_create", "Message");
                }
            }
            return View(bookstore);
        }

        /// <summary>
        /// 書局資料刪除頁面
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public ActionResult Delete(long? no)
        {
            ViewBag.Title = "Delete Data";
            if (no == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            bookstore bookstore = BOB.bookstores.Find(no);
            if (bookstore == null)
            {
                return HttpNotFound();
            }

            return View(bookstore);
        }

        /// <summary>
        /// 書局資料刪除功能
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long no)
        {
            bookstore bookstore = BOB.bookstores.Find(no);

            //移除關聯//////////////////////////////////////////
            var orders = BOB.orders.Where(s => s.no == no);
            if (orders != null)
            {
                foreach (var od in orders)
                {
                    BOB.orders.Remove(od);
                }
            }
            ///////////////////////////////////////////////////
            BOB.bookstores.Remove(bookstore);
            BOB.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 書局的書籍類別數量的輸出頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult BookDetail()
        {
            ViewBag.Title = "Detail Data";
            var bookstores_amount = (BOB.bookstores
                        .GroupJoin(
                                              BOB.orders,
                                              a => a.no,
                                              b => b.no,
                                             (a, g) =>
                                                        new BookLists.BookAll
                                                                    {
                                                                        name = a.name,
                                                                        amount = g.Count()
                                                                    }
                                                )).ToList();

            return View(bookstores_amount);
        }

        /// <summary>
        /// 書局資料編輯頁面
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public ActionResult Edit(long? no)
        {
            
            ViewBag.Title = "Edit Data";
            if (no == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            bookstore bookstore = BOB.bookstores.Find(no);
            if (bookstore == null)
            {
                return HttpNotFound();
            }

            return View(bookstore);
        }

        /// <summary>
        /// 書局資料編輯功能
        /// </summary>
        /// <param name="bookstore"></param>
        /// <returns></returns>

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(bookstore bookstore)
        {
            bool IsAvailable = false;
           
            if (ModelState.IsValid)
            {
                IsAvailable = datacheck(ModelState, bookstore,2);
                if (IsAvailable == true)
                {
                    BOB.Entry(bookstore).State = EntityState.Modified;
                    BOB.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["no"] = bookstore.no.ToString();
                    return RedirectToAction("error_edit","Message");
                }
               
            }
            return View(bookstore);
        }

        /// <summary>
        /// 書局資料輸出頁面
        /// </summary>
        /// <returns></returns>
        /// 
       
        public ActionResult Index()
        {
            ViewBag.Title = L10N.Resource.BookStoresData;
            var bookstores = BOB.bookstores;
            //  var orders = BOB.orders.Include(i => i.book).Include(i => i.bookstore);

            return View(bookstores.ToList());
        }

        public ActionResult Detail(long? no)
        {
            ViewBag.Title = "Book Detail Data";

            if (no == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            bookstore bookstore = BOB.bookstores.Find(no);
            if (bookstore == null)
            {
                return HttpNotFound();
            }

            ViewBag.BookStoreName = bookstore.name + "之書藉明細資料";
            var detail = (
                                    from a in BOB.books
                                    from b in BOB.orders
                                    where b.no == no && a.id == b.id
                                    select new BookLists.BookSelect { author = a.author, bookname = a.bookname, quantity = b.quantity }).ToList();
            return View(detail);
        }

       
        #region function

        /// <summary>
        /// 檢查bookstore資料中的書名和排名是否與資料庫資料重複，待修改
        /// </summary>
        /// <param name="ModelState"></param>
        /// <param name="bookstore"></param>
        /// <returns></returns>
        private bool datacheck(ModelStateDictionary ModelState, bookstore bookstore, int caseSwitch)
        {
            bool blsAvailable = true;
          
            switch (caseSwitch)
            {
               case 1://create功能
                 if (BOB.bookstores.Any(z => z.name == bookstore.name) || BOB.bookstores.Any(z => z.rank == bookstore.rank))
                    

                    {
                        blsAvailable = false;
                    }
                   break;
                case 2://edit功能
                   if (BOB.bookstores.Any(z => z.name == bookstore.name) && BOB.bookstores.Any(z => z.rank == bookstore.rank))
                     
                       {
                           blsAvailable = false;
                       }
                   break;
            }

           
            return (blsAvailable);
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                BOB.Dispose();
            }
            base.Dispose(disposing);
        }
    }

        #endregion function
}