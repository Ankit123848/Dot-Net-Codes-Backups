using FOOD_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FOOD_PROJECT.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        
             FoodDB db = new FoodDB(); // Replace PaymentDbContext with your actual DbContext class



            // GET: Payment
            public ActionResult Index()
            {
                var payments = db.Payments.ToList();
                return View(payments);
            }



        // Cash on Delivery Payment
        public ActionResult CashOnDelivery()
        {
            // Simulate a list of cart items (replace this with your actual cart data)
            //// List<Cart> cartItems = new List<CartItem>
            //var userInCookie = Request.Cookies["UserInfo"];
            //int iduser = Convert.ToInt32(userInCookie["idUser"]);
            //List<Cart> li = TempData["cart"] as List<Cart>;
            float totalBill = (float)TempData["Total"]; // Calculate the total bill

            // ... (the rest of your code)
            //// List<Cart> cartItems = new List<CartItem>
            //var userInCookie = Request.Cookies["UserInfo"];
            //int iduser = Convert.ToInt32(userInCookie["idUser"]);
            //TempData["TotalBillForCashOnDelivery"] = totalBill; 

            ViewBag.TotalBill = totalBill;



            return View();
        }



        [HttpPost]
            public ActionResult ProcessCashOnDelivery(Payment payment)
            {
			//Implement logic to process cash on delivery payment

			// You can save payment details to the database, send notifications, etc.
			db.Payments.Add(payment);
			db.SaveChanges();
			return RedirectToAction("PaymentSuccess");
			//var userInCookie = Request.Cookies["UserInfo"];
			//int iduser = Convert.ToInt32(userInCookie["idUser"]);
			//List<Cart> li = TempData["cart"] as List<Cart>;
			//InvoiceModel invoice = new InvoiceModel();
			//invoice.FKUserID = iduser;
			//invoice.DateInvoice = System.DateTime.Now;
			//invoice.Total_Bill = (float)TempData["Total"];
			//db.InvoiceModels.Add(invoice);
			//db.SaveChanges();
			//foreach (var item in li)
			//{
			//    Order odr = new Order();
			//    odr.FkProdId = item.id;
			//    odr.FkInvoiceID = invoice.ID;
			//    odr.Order_Date = System.DateTime.Now;
			//    odr.Qty = item.qty;
			//    odr.Unit_Price = (int)item.price;
			//    odr.Order_Bill = item.bill;
			//    db.Orders.Add(odr);
			//    db.SaveChanges();
			//}

			//TempData.Remove("total");
			//TempData.Remove("cart");
			//TempData.Keep();
			//return RedirectToAction("Index");
		}
        public ActionResult PaymentSuccess()
        {
            // Display a success message or receipt
            return View();
        }



        // Dispose of the DbContext when done
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }

}


// Card Payment
//public ActionResult CardPayment()
//    {
//        return View();
//    }



//[HttpPost]
//public ActionResult ProcessCardPayment(Payment payment)
//{
//    // Implement logic to process card payment
//    // You can validate card details, interact with payment gateways, save to the database, etc.
//    db.Payments.Add(payment);
//    db.SaveChanges();
//    return RedirectToAction("PaymentSuccess");
//}





// UPI Payment
//public ActionResult UpiPayment()
//{
//    return View();
//}

//     [HttpPost]
//     [ValidateAntiForgeryToken]
//     public ActionResult ProcessUpiPayment(Payment payment)
//     {
//         // Perform validation and error handling as needed



//         // Example: Call the UPI payment gateway API
//         var gateway = new UpiPaymentGateway(); // Replace with the actual gateway class
//         var response = gateway.MakePayment(payment.UpiId, payment.Amount);



//if (!response.IsSuccess)
//{
//	// Payment failed
//	// Handle the error, display an error message, or redirect to a failure page
//	ModelState.AddModelError(string.Empty, "UPI payment failed. Please try again.");
//	return View("UpiPayment", payment);
//}
//else
//{
//	// Payment was successful
//	// Save payment details to the database, send notifications, etc.
//	db.Payments.Add(payment);
//	db.SaveChanges();
//	return RedirectToAction("PaymentSuccess");
//}
//}







// Common Success Page
