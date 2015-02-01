using System.Web.Mvc;

namespace AspNetMvc.BasicController
{
    public class GreetingsController : Controller
    {
        public string Hello()
        {
            return "<html><body><p>Hello, world!</p></body></html>";
        }
    }
}