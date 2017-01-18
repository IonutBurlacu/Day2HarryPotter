using HarryPotter.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterLib
{
    public class TwoPayment : IPayment
    {
        public decimal GetCost(IEnumerable<IHarryPotterBook> books)
        {
            return books.Sum(b => b.count * b.price) * (decimal)0.95;
        }
    }
}
