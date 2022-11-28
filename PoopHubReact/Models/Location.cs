using System;
namespace PoopHubReact.Models
{
	public class Location
	{
        public double Lat { get; set; }
        public double Long { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }

        public Location()
		{
		}
	}
}

