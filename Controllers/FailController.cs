using Microsoft.AspNetCore.Mvc;

namespace pc4.Controllers
{
    public class FailController : Controller
    {
        public IActionResult SubirFail(){
            return View();
        }
        
         public IActionResult ComentarioFoto(){
            return View();
        }
    }
}