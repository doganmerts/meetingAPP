using meetingAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingAPP.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // var greeting = saat>12 ? "İyi Günler":"Günaydın";
            // ViewBag.Selamlama = saat>12 ? "İyi Günler":"Günaydın";
            // ViewBag.Username = "Mert";
            ViewData["Selamlama"] = saat>12 ? "İyi Günler" : "Günaydın";
            ViewData["Username"] = "Merrt";
            var meetingInfo = new MeetingInfo(){
                Id=1,
                Location = "İstanbul, Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = 100
            };
            return View(meetingInfo);
        }
    }
}