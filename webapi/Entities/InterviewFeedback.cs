namespace webapi.Entities
{
    public class InterviewFeedback
    {
        public int Id { get; set; }
        public Interview Interview { get; set; }
        public int InterviewId { get; set; }
        public Account Rekruter { get; set; }
        public int RekruterId { get; set; }
        public string Feedback { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
