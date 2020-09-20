namespace TicketBasket.Models.Domain
{
    public class EventTag : Record
	{
		[Required]
		[StringLength(40)]
		public string name { get; set; }

		public virtual Events events { get; set;}

		public string eventId { get; set;}
	}
}
