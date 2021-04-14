using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithEFCore.Models
{
    public class Post
    {
        public int Id { get; set; } //Id, ID, PostId
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
