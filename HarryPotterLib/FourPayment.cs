using HarryPotter.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterLib
{
    public class FourPayment : IPayment
    {
        public decimal GetCost(IEnumerable<IHarryPotterBook> books, int setCount)
        {
            return books.Sum(b => b.price * setCount) * (decimal)0.8;
        }
    }
}
