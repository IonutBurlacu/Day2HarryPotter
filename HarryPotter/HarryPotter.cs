using HarryPotter.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class HarryPotter
    {
        public decimal GetCost(IEnumerable<IHarryPotterBook> books)
        {
            decimal cost = 0;
            if (books.Count() == 2)
            {
                cost = books.Sum(b => b.count * b.price) * (decimal)0.95;
            }
            else
            {
                cost = books.Sum(b => b.count * b.price);
            }
            return cost;
        }
    }
}
