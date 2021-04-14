using PresentationLayerAndRazorSyntax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayerAndRazorSyntax.ViewModels
{
    public class BookVerleihVM // Umfasst eine ganze View/Formular
    {
        Book CurrentBook { get; set; }

        public DateTime GeliehenAm { get; set; }
        public Customer Customer { get; set; }

    }
}
