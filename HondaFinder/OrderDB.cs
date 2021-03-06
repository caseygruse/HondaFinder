﻿using HondaFinder.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HondaFinder
{
    class OrderDB
    {
        public static void AddOrder(CustomerOrder o)
        {
            //create db
            HondaDBContext context = new HondaDBContext();
            //add customer c to database
            context.CustomerOrders.Add(o);
            //save changes
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            var context = new HondaDBContext();
            CustomerOrder o = context.CustomerOrders.Find(id);

            context.CustomerOrders.Remove(o);
            context.SaveChanges();

        }

        public static void Update(CustomerOrder o)
        {
            HondaDBContext context = new HondaDBContext();

            //tell EF this product has only been modified
            //its already in the db
            context.Entry(o).State = EntityState.Modified;

            //sends update query to the database
            context.SaveChanges();
        }
    }
}
