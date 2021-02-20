using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyon.Models
{
    public class Car : BaseHome
    {
        public string CarCode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public double KM { get; set; }
        public int TotalCar { get; set; }
        public decimal? Price { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
