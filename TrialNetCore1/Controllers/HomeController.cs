using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrialNetCore1.IService;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrialNetCore1.Controllers
{    
    public class HomeController : Controller
    {       
        private readonly IBookRepository _bookRepository;
        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Daftar Buku";
            var books = _bookRepository.GetAllBooks().OrderBy(b => b.Judul);
            return View(books);
        }
    }
}
