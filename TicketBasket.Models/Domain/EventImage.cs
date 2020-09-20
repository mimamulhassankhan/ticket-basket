namespace TicketBasket.Models.Domain
{
    public class EventImage : Record
	{
		[Required]
		[StringLength(256)]
		public string imageUrl { get; set; }

		[StringLength(256)]
		public string thumbUrl { get; set; }

		public virtual Events events { get; set;}

		public string eventId { get; set;}
	}
}
