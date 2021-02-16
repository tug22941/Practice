using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Books
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public double TotalSales { get; set; }
        public int TotalRented { get; set; }
        public int TotalSold { get; set; }

        public Books()
        {

        }

    }
}
