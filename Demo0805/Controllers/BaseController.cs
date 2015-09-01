using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using Demo0805.Helpers;

namespace Demo0805.Controllers
{
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = null;

            // Attempt to read the culture cookie from Request
            HttpCookie cultureCookie = Request.Cookies["_culture"];
            if (cultureCookie != null)
                cultureName = cultureCookie.Value;
            else
                cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ?
                        Request.UserLanguages[0] :  // obtain it from HTTP header AcceptLanguages
                        null;
            // Validate culture name
            cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe

            // Modify current thread's cultures            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
        public ActionResult SetCulture(string culture, string url)
        {
            // 取得合適的已實作語系名稱
            culture = CultureHelper.GetImplementedCulture(culture);

            // 將語系名稱儲存於cookie
            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;   // 更新cookie值
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.HttpOnly = false;
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddMonths(3);
            }
            Response.Cookies.Add(cookie);
            return Redirect(url);//修改語系後 ，返回原來的網址
        }
	}
}