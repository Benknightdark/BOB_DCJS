using Demo0805.Helpers;
using Demo0805.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using L10N;

namespace Demo0805.Controllers
{
    public class BooksController : BaseController
    {
        private BOBEntities BOB = new BOBEntities();

        /// <summary>
        /// 書籍資料輸出頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = Resource.BooksData;
            var books = BOB.books;
            return View(books.ToList());
        }

        /// <summary>
        /// 新增書籍資料
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 新增功能
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(book book)
        {
            bool IsAvailable = false;
            if (ModelState.IsValid)//判斷valiation的驗證是否通過
            {
                IsAvailable = datacheck(ModelState, book, 1);
                if (IsAvailable == true)
                {
                    BOB.books.Add(book);
                    BOB.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("error_create", "Message");
                }
            }
            return View(book);
        }

        /// <summary>
        /// 刪除書籍資料頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(long? id)
        {
            ViewBag.Title = "Delete Data";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            book book = BOB.books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        /// <summary>
        /// 刪除書籍資料功能
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            book book = BOB.books.Find(id);

            //移除關聯//////////////////////////////////////////
            var orders = BOB.orders.Where(s => s.id == id);
            if (orders != null)
            {
                foreach (var od in orders)
                {
                    BOB.orders.Remove(od);
                }
            }
            ///////////////////////////////////////////////////
            BOB.books.Remove(book);
            BOB.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 書籍資料編輯頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(long? id)
        {
            ViewBag.Title = "Edit Books Data";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            book book = BOB.books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        /// <summary>
        /// 書籍資料編輯功能
        /// </summary>
        /// <param name="bookstore"></param>
        /// <returns></returns>

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(book book)
        {
            bool IsAvailable = false;

            if (ModelState.IsValid)
            {
                IsAvailable = datacheck(ModelState, book, 2);
                if (IsAvailable == true)
                {
                    BOB.Entry(book).State = EntityState.Modified;
                    BOB.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["no"] = book.id.ToString();
                    return RedirectToAction("error_edit", "Message");
                }
            }
            return View(book);
        }
    


        #region function

        /// <summary>
        /// 判斷書名和作者是否重複，待修改
        /// </summary>
        /// <param name="ModelState"></param>
        /// <param name="book"></param>
        /// <returns></returns>
        private bool datacheck(ModelStateDictionary ModelState, book book, int caseSwitch)
        {
            bool blsAvailable = true;
            switch (caseSwitch)
            {
                case 1://create功能
                    if (BOB.books.Any(z => z.bookname == book.bookname && z.publisher == book.publisher && z.author == book.author) == true
                      ||
                      BOB.books.Any(z => z.bookname == book.bookname && z.author == book.author) == true
                        ||
                        BOB.books.Any(z => z.bookname == book.bookname && z.publisher == book.publisher) == true
                        )
                    {
                        blsAvailable = false;
                    }
                    break;
                case 2://edit功能
                    if (BOB.books.Any(z => z.bookname == book.bookname) && BOB.books.Any(z => z.author == book.author))
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