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

            int paymentSetCount = 0;
            while (books.Any(x => x.count > paymentSetCount))
            {
                IEnumerable<IHarryPotterBook> bookSets = books.Where(x => x.count > paymentSetCount);
                int bookCount = bookSets.Count();
                IPayment payment = GetPayment(bookCount);
                int setCount = bookSets.Min(x => x.count) - paymentSetCount;
                cost += payment.GetCost(bookSets, setCount);
                paymentSetCount += setCount;
            }
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
