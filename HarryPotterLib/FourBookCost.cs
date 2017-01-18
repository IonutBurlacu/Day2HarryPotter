using HarryPotter.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterLib
{
    public class FourBookCost
    {
        public decimal GetCost(IEnumerable<IHarryPotterBook> books)
        {
            return books.Sum(b => b.price * b.count) * (decimal)0.8;
        }
    }
}
