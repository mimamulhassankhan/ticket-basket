using System;

namespace TicketBasket.Models.Domain
{
    public class Ticket : Record
	{
        public Ticket()
        {
            createdOn = DateTime.UtcNow;
        }
        
		[Required]
		[StringLength(10)]
		public string barCode { get; set; }
		public int? discount { get; set; }

		[Column(TypeName = "decimal(18, 2")]
		public decimal finalPrice { get; set; }
		public string place { get; set; }
		public DateTime createdOn { get; set; }
		public virtual Events events { get; set;}
		public string eventId { get; set; }
		public virtual UserProfile userProfile { get; set;}
		public string userProfileId { get; set; }

	}
}
