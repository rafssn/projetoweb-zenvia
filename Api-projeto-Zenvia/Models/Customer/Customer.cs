using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_projeto_Zenvia.Models.Customer
{
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Fied must be numeric")]
        public string Cpf { get; set; }

        [Required]
        [MaxLength(7)]
        [MinLength(7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Fied must be numeric")]
        public string Rg { get; set; }

        public IList<Telephone> Telephones { get; set; }

        public IList<Address> Adresses { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string LinkedIn { get; set; }
    }
}
