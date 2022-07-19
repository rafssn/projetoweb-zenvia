using System.ComponentModel.DataAnnotations;

namespace Api_projeto_Zenvia.Models.Customer
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string AddressName { get; set; }

        [Required]
        public string Street { get; set; }

        public int? Number { get; set; }

        public string Complement { get; set; }
    }
}
