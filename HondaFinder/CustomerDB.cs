using HondaFinder.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HondaFinder
{
	public static class CustomerDB
	{
		public static void AddCustomer(Customer c)
		{
			//create db
			HondaDBContext context = new HondaDBContext();
			//add customer c to database
			context.Customers.Add(c);
			//save changes
			context.SaveChanges();
		}

        public static void Delete(int id)
        {
            var context = new HondaDBContext();
            Customer c = context.Customers.Find(id);

            context.Customers.Remove(c);
            context.SaveChanges();

        }

        public static List<Customer> GetAllCustomers()
        {
            HondaDBContext context = new HondaDBContext();

            return context.Customers
                            .OrderBy(c => c.LastName)
                            .ToList();
        }

        public static Customer GetCustomer(int id)
        {
            HondaDBContext context = new HondaDBContext();

            return context.Customers.Find(id);
        }

		//public static bool CheckForCustomerID(int id)
		//{
		//	HondaDBContext context = new HondaDBContext();
		//	try
		//	{
		//		context.Customers.Find(id);
		//	}
		//}

        public static void Update(Customer c)
        {
            HondaDBContext context = new HondaDBContext();

            //tell EF this product has only been modified
            //its already in the db
            context.Entry(c).State = EntityState.Modified;

            //sends update query to the database
            context.SaveChanges();
        }
    }
}
