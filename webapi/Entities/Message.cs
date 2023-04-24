namespace webapi.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public Account Sender { get; set; }
        public int SenderId { get; set; }
        public Account Recipient { get; set; }
        public int RecipientId { get; set; }
        public DateTime DateofDispatch { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
    }
}
