namespace webapi.Entities
{
    public class GroupPost
    {
        public int Id { get; set; }
        public UserGroup Group { get; set; }
        public int GroupId { get; set; }
        public Account Author { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public List<GroupComment> Comments { get; set; }
    }
}
