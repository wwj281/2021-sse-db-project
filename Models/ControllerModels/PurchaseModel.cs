﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMall.Models
{
    public class CommodDetail
    {
        public string ID { get; set; }
        public int Amount { get; set; }
    }

    public class CartCommodity
    {
        public string amount { get; set; }
        public string commodityId { get; set; }
    }

    public class Cart
    {
        public List<CartCommodity> cart { get; set; }
    }
}
