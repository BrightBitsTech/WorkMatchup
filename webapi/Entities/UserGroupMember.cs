using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class UserGroupMember
    {
        public int Id { get; set; }
        public UserGroup Group { get; set; }
        public int GroupId { get; set; }
        public Account Member { get; set; }
        public int MemberId { get; set; }
        public DateTime DateJoined { get; set; }
        public MembershipRole Role { get; set; }
    }
}
