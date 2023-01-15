#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineReservations.Models
{
    public class BookingDetails
    {
        [Key]
        public int BookingID { get; set; }

        [Display(Name = "De la")]
        public string From { get; set; }
        [Display(Name = "La")]
        public string To { get; set; }
        [Display(Name = "Ora de plecare")]
        public DateTime DepartureTime { get; set; }
        [Display(Name = "Timp de întoarcere")]
        public DateTime ReturnTime { get; set; }
        [Display(Name = "Locuri")]
        public int Seats { get; set; }
      


        [Display(Name = "Prețul biletului")]
        public int TicketsId { get; set; }
        [ForeignKey("TicketsId")]
        public Tickets Tickets { get; set; }


        public string userId { get; set; }
        [Display(Name = "Preț bilet")]
        public int TicketPrice { get; set; }
        [Display(Name = "Starea biletului")]
        public string TicketStatus { get; set; }

        public int RouteId { get; set; }
    }
}
