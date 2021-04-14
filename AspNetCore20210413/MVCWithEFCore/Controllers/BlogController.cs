using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCWithEFCore.Data;
using MVCWithEFCore.Models;

namespace MVCWithEFCore.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDbContext _context;

        public BlogController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: Blog
        public async Task<IActionResult> Index()
        {

            //Task<List<Blog>> myTaskList = _context.Blogs.ToListAsync();
            //myTaskList.Wait();


            //List<Blog> myBlogList = await _context.Blogs.ToListAsync();

            return View(await _context.Blogs.ToListAsync());
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Blog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]/*<!-- Shützt vor CrossSiteAttacks -->*/
        public async Task<IActionResult> Create([Bind("Id,Title,Content,CreatedAt,AutorEmail")] Blog blog)
        {

            if (blog.AutorEmail == "Kevin.Winter.Privat@gmail.com" && blog.Title == "C#")
                ModelState.AddModelError("Autor", "Lieber Kevin, du hast doch schon ein Artikel übver dieser Thema geschrieben");


            if (ModelState.IsValid)
            {
                _context.Blogs.Add(blog); //Markiere einen DAtensatz, dass díeser in die Tabelle Blog hinzugefügt wird
                await _context.SaveChangesAsync(); // Datensatz wird in Tabelle gespeicher (SQL Query wird im Hintergrund erstellt) 
                return RedirectToAction(nameof(Index)); //Rufe im selben Controller die Action-Methode Index auf
            }
            return View(blog);
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog); //Formular mit bestehenden Datensatz wird angezeigt
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,CreatedAt,AutorEmail")] Blog blog) //Blog ist der bearbeitete Datensatz
        {
            if (id != blog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid) //Ist der Datensatz nach der modifizierung noch Valide? 
            {
                try
                {
                    _context.Update(blog); //Markiere, dass ein Datenatz modifiziert wird
                    await _context.SaveChangesAsync(); //Modifizerungen werden in DB übertragen
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }
    }
}
