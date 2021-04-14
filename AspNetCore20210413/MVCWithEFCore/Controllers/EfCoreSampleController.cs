using Microsoft.AspNetCore.Mvc;
using MVCWithEFCore.Data;
using MVCWithEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithEFCore.Controllers
{
    public class EfCoreSampleController : Controller
    {
        private readonly BlogDbContext _context;
        //ctor + tab + tab => Konstruktor
        public EfCoreSampleController(BlogDbContext context)
        {
            _context = context;
        }
        
        
        public IActionResult Index()
        {
            //Variante 1: Linq Ausdrück

            var blogs = from abc in _context.Blogs
                        where abc.CreatedAt > new DateTime(2020, 08, 23)
                        select abc;


            //Variante 2: Linq-Methoden und Lambda ist der Ausdruck
            IList<Blog> blogs1 = _context.Blogs.Where(n => n.CreatedAt > new DateTime(2020, 08, 23))
                .OrderBy(c => c.AutorEmail)
                .ThenBy(o => o.CreatedAt)
                .ToList();



            //return View(blogs.ToList());

            return View(_context.Blogs.ToList());
        }


        //Aktuelle PaggingSeite -> Seite 3 / 20 Datensätze werden angezeigt = Ersten 40 Datensätze werden ignoriert und ab da an, werden 20 Datensatze genommen
        public IActionResult IndexWithPagging(int pageSize, int entriesPerPage)
        {
            IList<Blog> myPaggingBlogs = _context.Blogs.Skip((pageSize - 1) * entriesPerPage).Take(entriesPerPage).ToList();


            return View(myPaggingBlogs);
        }
    }



}
