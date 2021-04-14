using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayerAndRazorSyntax.Models
{
    public class Book //Repräsentier z.b eine Tabelle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descripton { get; set; }
        public string Autor { get; set; }
    }
}
