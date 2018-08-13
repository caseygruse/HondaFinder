using HondaFinder.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HondaFinder
{
	public static class VehicalDB
	{
		/// <summary>
		/// adds a Vehical Object to the dataBase
		/// </summary>
		/// <param name="v"></param>
		public static void AddVehicle(Vehicle v)
		{
			//creates db context
			HondaDBContext context = new HondaDBContext();
			//adds the the object to database
			context.Vehicles.Add(v);
			//saves the changes
			context.SaveChanges();
		}

        public static List<Vehicle> GetAllVehicles()
        {
            HondaDBContext context = new HondaDBContext();

            return context.Vehicles
                            .OrderBy(c => c.Model)
                            .ToList();
        }

        public static Vehicle GetVehicle(int id)
        {
            HondaDBContext context = new HondaDBContext();

            return context.Vehicles.Find(id);
        }

        public static List<Vehicle> GetVehiclesByModel(string model)
        {
            HondaDBContext context = new HondaDBContext();

            List<Vehicle> vehicles = (from v in context.Vehicles
                         where v.Model == model
                         select v).ToList();

            return vehicles;
        }

        public static List<Vehicle> GetVehiclesByYear(int year)
        {
            HondaDBContext context = new HondaDBContext();

            List<Vehicle> vehicles = (from v in context.Vehicles
                                      where v.Year == year
                                      select v).ToList();

            return vehicles;
        }

        public static List<Vehicle> GetVehiclesByPrice(double lowPrice, double highPrice)
        {
            HondaDBContext context = new HondaDBContext();

            List<Vehicle> vehicles = (from v in context.Vehicles
                                      where v.Price <= highPrice && v.Price >= lowPrice
                                      select v).ToList();

            return vehicles;
        }

        public static List<Vehicle> GetVehiclesByMileage(int mileage)
        {
            HondaDBContext context = new HondaDBContext();

            List<Vehicle> vehicles = (from v in context.Vehicles
                                      where v.Mileage < mileage
                                      select v).ToList();

            return vehicles;
        }

        public static void Update(Vehicle v)
        {
            HondaDBContext context = new HondaDBContext();

            //tell EF this product has only been modified
            //its already in the db
            context.Entry(v).State = EntityState.Modified;

            //sends update query to the database
            context.SaveChanges();
        }
    }
}
