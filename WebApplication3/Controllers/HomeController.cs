using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string r = "")
        {
            string msg = string.Empty;
            string[] arr =
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
            };
            for (int i = 0; i < arr.Length; i++)
            {
                if (r == arr[i])
                {
                    msg = string.Format("{0} match ", arr[i]);
                }
            }
            msg = null;
            JsonContent d =  JsonContent.Create(msg);
            d.ToString();

            return View(msg);
        }
    }
}
