using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebRuou.Models;

namespace WebRuou.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        DBRuouEntities db = new DBRuouEntities();
        // GET: Admin/Order
        public ActionResult Index( int? page)
        {
            int pageSize = 10;
            int pageNum = (page ?? 1);

            var orders = db.Orders.ToList().ToPagedList(pageNum, pageSize);
            return View(orders);
        }
    }
}