using HarryPotter.Books;
using HarryPotterLib;
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
            int bookCount = books.Count();
            IPayment payment = GetPayment(bookCount);
            cost = payment.GetCost(books);
            return cost;
        }

        private IPayment GetPayment(int bookCount)
        {
            IPayment payment = null;
            if (bookCount == 5)
            {
                payment = new FivePayment();
            }
            else if (bookCount == 4)
            {
                payment = new FourPayment();
            }
            else if (bookCount == 3)
            {
                payment = new ThreePayment();
            }
            else if (bookCount == 2)
            {
                payment = new TwoPayment();
            }
            else
            {
                payment = new OnePayment();
            }
            return payment;
        }
    }
}
