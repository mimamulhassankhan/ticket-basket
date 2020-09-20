namespace TicketBasket.Models.Domain
{
    public class JobApplocation : Record
	{
        public JobApplocation()
        {
            applicationDate = DateTime.UtcNow;
        }
        
		public string position { get; set; }
		public string description { get; set; }
		public string cvUrl { get; set; }
		public JobApplocationStatus status { get; set; }

		public virtual UserProfile appliedUser { get; set;}
		[ForeignKey(nameof(appliedUser))]
		public string appliedUserId { get; set; }

		public virtual UserProfile organizer { get; set;}
		[ForeignKey(nameof(organizer))]
		public string organizerId { get; set; }

        public DateTime applicationDate { get; set;}

	}

    public enum JobApplocationStatus
	{
		pending = 0,
		reviewing = 1,
		rejected = 2,
		accepted = 3
	}
}
