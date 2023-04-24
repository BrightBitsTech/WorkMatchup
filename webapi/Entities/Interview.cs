using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class Interview
    {
        public int Id { get; set; }
        public Account Candidate { get; set; }
        public int CandidateId { get; set; }
        public Account Recruiter { get; set; }
        public int RecruiterId { get; set; }
        public JobOffer JobOffer { get; set; }
        public int JobOfferId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Description { get; set; }
        public InterviewStatus Status { get; set; }
    }
}
