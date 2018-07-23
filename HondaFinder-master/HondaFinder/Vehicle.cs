using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Vehicle
{
	public Vehicle()
	{
	}
	[Key]
    public int VinNumber { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public int Mileage { get; set; }

    public string Condition { get; set; }

    public double Price { get; set; }

    public string Color { get; set; }

    public int Cost { get; set; }

}
