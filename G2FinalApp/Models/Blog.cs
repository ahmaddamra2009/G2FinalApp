using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G2FinalApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDesc { get; set; }
        public string BlogImg { get; set; }
        public DateTime PublishDate { get; set; }
        public bool isPublished { get; set; }
    }
}
