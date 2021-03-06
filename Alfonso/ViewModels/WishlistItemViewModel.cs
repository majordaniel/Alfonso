﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alfonso.ViewModels
{
    public class WishlistItemViewModel
    {
        public int Id { get; set; }
        public int CatalogItemId { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
