﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public DateTime LastUpdated { get; set; }
        public byte[] Image { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
