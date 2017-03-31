using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout

            /// <summary>
            /// 測試主板頁面
            /// </summary>
            /// <returns></returns>
        public ActionResult Index()
        {
            
            return View();
        }
    }
}