namespace CNMwebapp.Models
{
    public class SquadMember
    {
        public int SquadMemberId { get; set; }
        public string JobId { get; set; }
        public string WorkerId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
