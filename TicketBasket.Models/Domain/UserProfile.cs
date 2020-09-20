using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBasket.Models.Domain
{
    public class UserProfile : Record
	{
		public UserProfile()
		{
			createdOn = DateTime.UtcNow;
		}
		[Required]
		[StringLength(25)]
		public string firstName { get; set; }

		[Required]
		[StringLength(25)]
		public string lastName { get; set; }

		[Required]
		[StringLength(25)]
		public string email { get; set; }

		[Required]
		[StringLength(25)]
		public string country { get; set; }

		[Required]
		[StringLength(25)]
		public string city { get; set; }

		public bool isOrganizer { get; set; }

		public DateTime createdOn { get; set; }

		public virtual List<Events> events { get; set;}

		public virtual List<Ticket> tickets { get; set;}

		public virtual List<WishlistEvent> wishlistEvent { get; set;}

		public virtual List<Like> likes { get; set;}

		public virtual List<JobApplocation> sentApplication { get; set;}
		public virtual List<JobApplocation> receivedApplication { get; set;}

	}
}
