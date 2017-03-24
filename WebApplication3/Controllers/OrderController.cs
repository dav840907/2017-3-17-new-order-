using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            //Models.OrderService orderService = new Models.OrderService();
            //  var order = orderService.GerOrderById("111");
            //  ViewBag.CustId = order.CustId;
            //  ViewBag.CustName = order.CustName;
            // return View();
         
            return View();
        }
        public ActionResult Index2(string id)
        {
            ViewBag.id = id;
            return View();
        }


        public ActionResult InsertOrder()
        {

            return View();
        }

        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order) {
            ViewBag.Desc1 = "ViewBag";
            ViewData["Desc2"] = "ViewData";
            TempData["Desc3"] = "TempData";
            return RedirectToAction("Index");
        }

    }
}