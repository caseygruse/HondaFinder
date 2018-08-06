using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CustomerOrder
{
	public CustomerOrder()
	{
        
	}
	[Key]
    public int OrderID { get; set; }
	
    public int VinNumber { get; set; }

    public int CustomerID { get; set; }

    public DateTime OrderDate { get; set; }


}
