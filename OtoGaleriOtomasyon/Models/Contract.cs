﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyon.Models
{
    public class Contract : BaseHome
    {
        public string Title { get; set; }
        public decimal DailyPrice { get; set; }
        public int Day { get; set; }
        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public int? CarId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Category Category { get; set; }
        public virtual Car Car { get; set; }
    }
}
