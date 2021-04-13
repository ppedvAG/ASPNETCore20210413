using Microsoft.AspNetCore.Mvc;
using PresentationLayerAndRazorSyntax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayerAndRazorSyntax.Controllers
{
    public class BookController : Controller
    {

        // Aufgabe des Controllers: 
        // 1.) Holt sich Daten her (Services oder direkt EF Core) und sammelt diese zusammen.
        //     Übergibt Daten an die UI (RazorView) 
        
        // 2.) Erhält Daten von der UI (Formulare) und gibt desen Daten weiter Richtung Datenbank 

        // 3.) Navigation unterhalb der Action-Methoten innerhalb und ausserhalb eines Controller. (Redirect) 

        public IActionResult Index() // GET METHODE -> Liefer ein Ergbnis an den Browser
        {
            //Daten kommen aus DB oder Service
            IList<Book> books = new List<Book>();
            books.Add(new Book() { Id = 1, Title = "Herr der Ringe", Autor = "Max und Moritz", Descripton = "Ist ein Fantasy Roman" });
            books.Add(new Book() { Id = 2, Title = "ES", Autor = "Steven King", Descripton = "Horror" });
            books.Add(new Book() { Id = 3, Title = "Heimweg", Autor = "Fritzek", Descripton = "Thriller" });
            return View(books); //Return View -> Rendere RazorView + _Layout zu einer Seite zusammen und sende das Ergebnis an den Browser
        }


        public IActionResult Edit (int id)
        {
            return View();
        }
    }
}
