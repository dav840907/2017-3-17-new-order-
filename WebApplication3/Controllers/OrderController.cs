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
        /// <summary>
        /// 訂單管理系統首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Models.OrderService orderService = new Models.OrderService();
            //  var order = orderService.GerOrderById("111");
            //  ViewBag.CustId = order.CustId;
            //  ViewBag.CustName = order.CustName;
            // return View();

            // Models.OrderService orderService = new Models.OrderService();
            //ViewBag.Data = orderService.GetOrders();

            List<SelectListItem> custData = new List<SelectListItem>();
            custData.Add(new SelectListItem()
            {
                Text = "叡揚資訊",
                Value = "1"
            });
            
            custData.Add(new SelectListItem() {
                Text = "軟網資訊",
                Value = "2"
             });
            ViewBag.custData=custData;
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