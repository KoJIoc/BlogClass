using BlogLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLibrary
{
	public class AnswerComment
	{
		public string TextOfComment { get; set; }
		public UserProfile AnswerCommentator { get; set; }
		public int Id { get; set; }
	}
}
