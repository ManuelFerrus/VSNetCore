﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ThreeLayers.ExampleApp.Entities
{
    public class Book
    {
        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public DateTime DatePublishBook { get; set; }
        public int NumberPages { get; set; }
        public float SalePrice { get; set; }
        public double PurchasePrice { get; set; }
        public bool IsAvaible { get; set; }
    }
}