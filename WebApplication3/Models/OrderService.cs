using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InsertOreder(Models.Order order)
        {
            //todo
        }

        /// <summary>
        /// 依照id取得訂單資料
        /// </summary>
        /// <returns></returns>
        public Models.Order GerOrderById(string id)
        {
            //todo
            Models.Order result = new Order();
            result.CustId = "FFF";
            result.CustName = "FFFF";
            return result;
        }

        /// <summary>
        /// 依照條件取得訂單資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrderByCondtion() {
            //todo
            return new List<Order>();
        }

        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeletOrderById()
        {
            //todo 
        }

        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder() {
            //tode
        }
    }
}