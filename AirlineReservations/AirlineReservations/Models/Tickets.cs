#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineReservations.Models
{
    //Ticket table
    public class Tickets
    {
        [Key]
        public int Id { get; set; }
        //from
        [Display(Name = "Bilet de la")]
        public string TicketFrom { get; set; }
        //to
        [Display(Name = "Bilet pentru")]
        public string TicletTo { get; set; }
        //time from
        [Display(Name = "Ora de plecare De la ")]
        public DateTime TimeFrom { get; set; }
        [Display(Name = "Ora de plecare către")]
        //time to
        public DateTime TimeTo { get; set; }
        //seats
        [Display(Name = "Scaun total")]
        public int TotalSeata { get; set; }


        [Display(Name = "O singură cale Preț")]
        public int SinglePrice { get; set; }
        [Display(Name = "Două moduri de preț")]
        public int TwoWaysPrice { get; set; }

        //forigen key relation with airline
        [Display(Name = "Selectați numele companiei aeriene")]
        public int AirlineID { get; set; }

        [ForeignKey("AirlineID")]
        public Airline Airline { get; set; }

        [Display(Name = "Selectați numele tipului de clasă")]
        public int ClassTypeID { get; set; }

        [ForeignKey("ClassTypeID")]
        public BookingClass bookingClass { get; set; }

        
    }
}
