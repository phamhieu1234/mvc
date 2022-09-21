using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using PhamTrungHieuBTH.Models;
using PhamTrungHieuBTH.Models.Process;

namespace PhamTrungHieuBTH.Movie.Controllers
{
    public class DemoController : Controller    
    {
        //khai bao class theo huong doi tuong
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        private dynamic message;

        public IActionResult Index ()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index(string heSoA, string heSoB)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        string thongbao = gpt.GiaiPhuongTrinhBacNhat(a, b);
        ViewBag.message = thongbao ; 
        return View();
      }
      [HttpPost]
      public IActionResult Creat(string heSoA, string heSoB, string heSoC)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        double c = Convert.ToDouble(heSoC);
        string thongbao = gpt.GiaiPhuongTrinhBacHai(a, b, c);
        ViewBag.message= thongbao ; 
        return View();
      }
    }
}