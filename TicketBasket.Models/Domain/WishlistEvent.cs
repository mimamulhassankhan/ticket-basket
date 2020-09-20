using System;

namespace TicketBasket.Models.Domain
{
    public class WishlistEvent : Record
	{
		public WishlistEvent()
		{
			createdOn = DateTime.UtcNow;
		}
        
		public DateTime createdOn { get; set; }
		public virtual Events events { get; set;}
		public string eventId { get; set; }
		public virtual UserProfile userProfile { get; set;}
		public string userProfileId { get; set; }
	}
}
