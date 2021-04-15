using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StateManagementMVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StateManagementMVCSample.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult ViewDataSample()
        {
            //Was macht ViewData -> Daten von Controller an die View übermitteln 
            
            //Initialisierung der ViewDate 

            ViewData["abc"] = "Hallo liebe Teilnehmer!";


            return View();
        }

        public IActionResult ViewBagSample()
        {
            ViewBag.Wetter = "Heute scheint die Sonne";
            ViewBag.Haribo = "Haribo schmeckt lecker";
            //Ist Wetter auch in ViewData enthalten. 

            return View();
        }

        public IActionResult FirstTempDataSample()
        {
            TempData["EmailAddress"] = "KevinW@ppedv.de";
            TempData["Id"] = 123;
            TempData.Keep(); 

            return View();
        }

        public IActionResult SecondTempDataSample()
        {
            return View();
        }
        public IActionResult ThirdTempDataSample()
        {
            return View();
        }

        public IActionResult SessionInit()
        {
            //SetInt32 ist eine Erweiterungs-Methode -> using Microsoft.AspNetCore.Http
            HttpContext.Session.SetInt32("Lottozahlen", 1234567);
            //SetString ist eine Erweiterungs-Methode -> using Microsoft.AspNetCore.Http
            HttpContext.Session.SetString("Wetter", "Heute schein die Sonne!");

            Person person = new Person() { Vorname = "Max", Nachname = "Muster" };

            string jsonString = JsonSerializer.Serialize(person);
            HttpContext.Session.SetString("PersonObj", jsonString);
            return View();
        }

        public IActionResult CookieSample()
        {
            return View();
        }


    }
}
