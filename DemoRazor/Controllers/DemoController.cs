using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoRazor.Models;

namespace DemoRazor.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Demo()
        {
            List<ThanhPho> lsTP = new List<ThanhPho>();
            ThanhPho tp;
            tp = new ThanhPho();
            tp.MaTP = 1;
            tp.TenTP = "Hà Nội";
            lsTP.Add(tp);
            tp = new ThanhPho();
            tp.MaTP = 2;
            tp.TenTP = "TP.Hồ Chí Minh";
            lsTP.Add(tp);

            //ViewBag dữ liệu động dùng để add dữ liệu
            ViewBag.tennaocungduoc = new SelectList(lsTP, "MaTP", "TenTP");

            return View();
        }
        [HttpPost]
        public ActionResult Demo(FormCollection f)
        {
            
            return View();
        }
    }
}