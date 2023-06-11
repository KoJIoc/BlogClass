using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLibrary
{
    public class Blog
    {
        public List<Article> Articles { get; set; } 
        public string Title { get; set; }
        public UserProfile Owner { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}
