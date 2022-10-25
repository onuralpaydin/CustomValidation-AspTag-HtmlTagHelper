using CustomValid_AspTag_HtmlTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomValid_AspTag_HtmlTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CustomerDetails()
        {
            //Customer sınıfı oluşturunuz
            //customerID,CompanyName,Age,Email,JoinDate,Enum CustomerType=> New=0, Regular ,Elite
            //Required , ERROR MESSAGE

            //html.

            ViewBag.postback = "Hayallerim";

            return View(new Customer());
        }

        [HttpPost]
        public IActionResult CustomerDetails(Customer customer)
        {
            //Customer sınıfı oluşturunuz
            //customerID,CompanyName,Age,Email,JoinDate,Enum CustomerType=> New=0, Regular ,Elite
            //Required , ERROR MESSAGE

            //html.
            return View(customer);
        }

        //2 sınıf person/ pet
        //ViewModel
        //pet 2/4/6/8 ayak sayısı.
        // hayvanın yaşı max 15.
        // hayvanın beslenme türü (etçil otçul hepçil.)
        // tasarim inputlar hata mesajları.
    }
}