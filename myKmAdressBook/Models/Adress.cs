using System.ComponentModel.DataAnnotations;

namespace myKmAdressBook.Models
{
    public class Adress
    {

        public int Id { get; set; }

        [Display(Name="Kundennummer")]
        [Required]
        public string CustumerId { get; set; }

        [Display(Name="Kundenname")]
        [Required]
        public string Name { get; set; }

        [Display(Name="Postleitzahl")]
        [Required]
        public string Postcode { get; set;  }

        [Display(Name="Ort")]
        [Required]
        public string City { get; set; }

        [Display(Name="Land")]
        [Required]
        public string Country { get; set; }

        [Display(Name="Straße")]
        [Required]
        public string Street { get; set; }

    }
}