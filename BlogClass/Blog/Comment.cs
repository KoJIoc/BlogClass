using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLibrary
{
    public class Comment
    {
        public string TextOfComment { get; set; }
        public List<Comment>? AnswerComments { get; set; }
        public UserProfile Commentator { get; set; }
        public int Id { get; set; }
    }
}
