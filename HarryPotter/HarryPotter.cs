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
            if (bookCount == 5)
            {
                cost = GetFiveBookCost(books);
            }
            else if (bookCount == 4)
            {
                cost = GetFourBookCost(books);
            }
            else if (bookCount == 3)
            {
                cost = GetThreeBookCost(books);
            }
            else if (bookCount == 2)
            {
                cost = GetTwoBookCost(books);
            }
            else
            {
                cost = GetOneBookCost(books);
            }
            return cost;
        }

        private static decimal GetFiveBookCost(IEnumerable<IHarryPotterBook> books)
        {
            FivePayment bookCost = new FivePayment();
            return bookCost.GetCost(books);
        }

        private static decimal GetFourBookCost(IEnumerable<IHarryPotterBook> books)
        {
            FourPayment bookCost = new FourPayment();
            return bookCost.GetCost(books);
        }

        private static decimal GetThreeBookCost(IEnumerable<IHarryPotterBook> books)
        {
            ThreePayment bookCost = new ThreePayment();
            return bookCost.GetCost(books);
        }

        private static decimal GetTwoBookCost(IEnumerable<IHarryPotterBook> books)
        {
            TwoPayment bookCost = new TwoPayment();
            return bookCost.GetCost(books);
        }

        private static decimal GetOneBookCost(IEnumerable<IHarryPotterBook> books)
        {
            OnePayment bookCost = new OnePayment();
            return bookCost.GetCost(books);
        }
    }
}
