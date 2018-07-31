﻿using HondaFinder.entity;
using System;
using System.Collections.Generic;
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
	}
}
