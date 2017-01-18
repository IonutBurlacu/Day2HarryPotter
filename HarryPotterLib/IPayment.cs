using HarryPotter.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterLib
{
    public interface IPayment
    {
        decimal GetCost(IEnumerable<IHarryPotterBook> books, int setCount);
    }
}
