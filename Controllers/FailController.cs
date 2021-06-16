using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pc4.Data;
using pc4.Models;
namespace pc4.Controllers
{
    public class FailController : Controller
    {
        private ApplicationDbContext _context;
        public FailController(ApplicationDbContext context){
            _context= context;
        }
        public IActionResult SubirFail(){
            return View();
        }
        [HttpPost]
        public IActionResult SubirFail(Fail f){
             if(ModelState.IsValid){
                _context.Add(f);
                _context.SaveChanges();

                return RedirectToAction("SubirFail");
            }
            return View(f);
        }
        public IActionResult ComentarioFoto(){
            var comentarios= _context.Comentarios.OrderBy(x => x.Id).ToList();
            return View(comentarios);
        }
    }
}