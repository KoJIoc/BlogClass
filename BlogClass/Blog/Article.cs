
namespace BlogLibrary
{
    public class Article
    {
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int Id { get; set; }
    }
}