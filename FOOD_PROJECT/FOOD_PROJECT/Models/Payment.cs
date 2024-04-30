using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FOOD_PROJECT.Models
{
	public class Payment
	{
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string MobileNo { get; set; }

    }
}
// public string TransactionId { get; set; }
//public string PaymentMethod { get; set; }
//public string CardNumber { get; set; }
//public string ExpiryDate { get; set; }
//public string CVV { get; set; }
