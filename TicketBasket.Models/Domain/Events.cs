using System;
using System.Collections.Generic;

namespace TicketBasket.Models.Domain
{
    public class Events : Record
	{
		public Events()
		{
			createdOn = DateTime.UtcNow;
		}
		
		[Required]
		[StringLength(80)]
		public string title { get; set; }

		[StringLength(1000)]
		public string description { get; set; }

		[Required]
		[StringLength(256)]
		public string coverImageUrl { get; set; }

		[Required]
		[StringLength(256)]
		public string location { get; set; }

		public int ticketCount { get; set; }

		public int views { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal price { get; set; }

		public DateTime createdOn { get; set; }

		public virtual UserProfile userProfile { get; set;}

		public string userProfileId { get; set; }

		public virtual List<EventTag> eventTags { get; set;}
		public virtual List<EventImage> eventImages { get; set;}
		public virtual List<Ticket> tickets { get; set;}
		public virtual List<WishlistEvent> wishlistEvent { get; set;}
		public virtual List<Like> likes { get; set;}
	}
}
