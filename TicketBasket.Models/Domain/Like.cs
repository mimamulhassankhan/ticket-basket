using System;

namespace TicketBasket.Models.Domain
{
    public class Like : Record
	{
		public Like()
		{
			likedOn = DateTime.UtcNow;
		}
		public DateTime likedOn { get; set; }
		public virtual Events events { get; set;}
		public string eventId { get; set; }
		public virtual UserProfile userProfile { get; set;}
		public string userProfileId { get; set; }
	}
}
