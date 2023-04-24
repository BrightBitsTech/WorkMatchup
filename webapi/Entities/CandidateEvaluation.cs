namespace webapi.Entities
{
    public class CandidateEvaluation
    {
        public int Id { get; set; }
        public Account Candidate { get; set; }
        public int CandidateId { get; set; }
        public Account Recruiter { get; set; }
        public int RecruiterId { get; set; }
        public JobOffer JobOffer { get; set; }
        public int JobOfferId { get; set; }
        public int Evaluation { get; set; }
        public string Comment { get; set; }
        public DateTime DateEvaluations { get; set; }
    }
}
