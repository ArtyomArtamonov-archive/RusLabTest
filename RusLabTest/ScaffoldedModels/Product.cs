using System;
using System.Collections.Generic;

namespace RusLabTest.ScaffoldedModels
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public long CreationDate { get; set; }
    }
}
