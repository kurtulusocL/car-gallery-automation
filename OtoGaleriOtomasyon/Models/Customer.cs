using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyon.Models
{
    public class Customer:BaseHome
    {
        public string IdentityNo { get; set; }
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }

        public int? CarId { get; set; }
        public virtual Car Car { get; set; }

        public ICollection<Contract> Contracts { get; set; }       
    }
}
