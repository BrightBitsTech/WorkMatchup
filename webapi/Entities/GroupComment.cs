namespace webapi.Entities
{
    public class GroupComment
    {
        public int Id { get; set; }
        public GroupPost Post { get; set; }
        public int PostId { get; set; }
        public Account Author { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
