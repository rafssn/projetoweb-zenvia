using System.ComponentModel.DataAnnotations;

namespace Api_projeto_Zenvia.Models.Customer
{
    public class Telephone
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string PhoneName { get; set; }

        [Required]
        [MaxLength(2)]
        [MinLength(2)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Fied must be numeric")]
        public string AreaCode { get; set; }

        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Fied must be numeric")] 
        public string PhoneNumber { get; set; }
    }
}
