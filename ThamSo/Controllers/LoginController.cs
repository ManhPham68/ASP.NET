using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThamSo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThongTinTaiKhoan(FormCollection f , string HoTen)
        {
            ViewBag.HoTen = HoTen;
            ViewBag.TaiKhoan = f.Get("txtTenDangNhap").ToString();
            return View();
        }
    }
}