using HondaFinder.entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
		public static void AddVehical(Vehicle v)
		{
			//creates db context
			HondaDBContext context = new HondaDBContext();
			//adds the the object to database
			context.Vehicles.Add(v);
			//saves the changes
			context.SaveChanges();
		}
	}
}
