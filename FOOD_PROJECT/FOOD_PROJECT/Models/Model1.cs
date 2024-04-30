using System;
using System.Data.Entity;
using System.Linq;

namespace FOOD_PROJECT.Models
{
    public class FoodDB : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FOOD_PROJECT.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public FoodDB()
            : base("name=FoodDB")
        {

        }
        public DbSet<Products> Products { get; set; }
        public DbSet<SignupLogin> SignupLogins { get; set; }
        public DbSet<AdminLogin> AdminLogins { get; set; }
        public DbSet<InvoiceModel> InvoiceModels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ContactModel> ContactModels { get; set; }
        //public DbSet<BlogModel> BlogModels { get; set; }

		public DbSet<Payment> Payments { get; set; }
        public DbSet<Cart> Carts { get; set; }



		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}