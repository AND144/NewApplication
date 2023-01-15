#nullable disable
using System.ComponentModel.DataAnnotations;

namespace AirlineReservations.Models
{
    //Airline table
    public class Airline
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Codul companiei aeriene")]
        public string Airlinecode { get; set; }
        
        [Display(Name = "Numele companiei aeriene")]
        public string AirlineName { get; set; }
    }
}
