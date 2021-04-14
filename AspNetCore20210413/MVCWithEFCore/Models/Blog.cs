using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithEFCore.Models
{
    public class Blog
    {
        //ID und Konventionen vor .EF Core 5 -> es wird eine ID immer benötigt
        public int Id { get; set; }
        //public Guid Id { get; set; } //GUID sind für OfflineAnwendung

        [Required] //Wird Richtung Datenbank und Richtung Frontend Aufgelöst
        [StringLength(100)]
        public string Title { get; set; }

        [DisplayName("Beitrag")] // DisplayName wird nur richtung Frontend aufgelöst
        
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        [EmailAddress] // Richtung Frontend Aufgelöst -> Validierung für Eingabe-Feld 
        public string AutorEmail { get; set; }

        //Navigation
        public ICollection<Post> Posts { get; set; }
    }
}
