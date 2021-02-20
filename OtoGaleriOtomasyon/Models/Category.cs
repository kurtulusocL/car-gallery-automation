using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyon.Models
{
    public class Category : BaseHome
    {        
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
