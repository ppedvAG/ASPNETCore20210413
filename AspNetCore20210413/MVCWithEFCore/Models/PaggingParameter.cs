using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithEFCore.Models
{
    public class PaggingParameter
    {
        public int CurrentPage { get; set; }

        public int EntriesPerPage { get; set; }
    }
}
