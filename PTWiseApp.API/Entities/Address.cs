using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWiseApp.API.Entities
{
    public class Address
    {
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        public string Country { get; set; }

        public string Postcode { get; set; }

        // 1-2-1 relationship for EITHER client OR trainer.. 
        // will result in some NULLs but not too many
        // fix at some point I guess (junction table?)

        public Client Client { get; set; }

        public Trainer Trainer { get; set; }

        public override string ToString()
        {
            var address = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(AddressLine1))
            {
                address.Append(AddressLine1);
                if (!string.IsNullOrWhiteSpace(AddressLine2) || !string.IsNullOrWhiteSpace(Country) || !string.IsNullOrWhiteSpace(Postcode))
                {
                    address.Append(", ");
                }
            }
            if (!string.IsNullOrWhiteSpace(AddressLine2))
            {
                address.Append(AddressLine2);
                if (!string.IsNullOrWhiteSpace(Country) || !string.IsNullOrWhiteSpace(Postcode))
                {
                    address.Append(", ");
                }
            }
            
            if (!string.IsNullOrWhiteSpace(Country))
            {
                address.Append(Country);
                if (!string.IsNullOrWhiteSpace(Postcode))
                {
                    address.Append(", ");
                }
            }
            if (!string.IsNullOrWhiteSpace(Postcode))
            {
                address.Append(Postcode);
            }

            return address.ToString();
        }

        public bool IsNullOrWhiteSpace()
        {
            return string.IsNullOrWhiteSpace(AddressLine1) &&
             string.IsNullOrWhiteSpace(AddressLine2) &&
                 string.IsNullOrWhiteSpace(Country) &&
                  string.IsNullOrWhiteSpace(Postcode);
        }
    }
}
