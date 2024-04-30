using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FOOD_PROJECT.Models
{
    public class Cart
    {
		public int cartId { get; set; }
		public int productId { get; set; }
        //[ForeignKey("id")]
     
        public string productName { get; set; }
        public string productPic { get; set; }
        public float price { get; set; }
        public int qty { get; set; }
        public float bill { get; set; }
        
    }
}