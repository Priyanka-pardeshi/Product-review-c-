using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview_Management
{
    class Review_product
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool Like { get; set; }

    }
}
