using OpenCvSharp;

namespace webapi.Entities
{
    public class Network
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Account> Members { get; set; }
    }
}
