namespace webapi.Entities
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Account Admin { get; set; }
        public int AdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public List<UserGroupMember> Members { get; set; }
    }
}
