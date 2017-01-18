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
            if (books.Count() == 5)
            {
                cost = GetFiveBookCost(books);
            }
            else if (books.Count() == 4)
            {
                cost = GetFourBookCost(books);
            }
            else if (books.Count() == 3)
            {
                cost = GetThreeBookCost(books);
            }
            else if (books.Count() == 2)
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
            return books.Sum(b => b.price * b.count) * (decimal)0.75;
        }

        private static decimal GetFourBookCost(IEnumerable<IHarryPotterBook> books)
        {
            return books.Sum(b => b.price * b.count) * (decimal)0.8;
        }

        private static decimal GetThreeBookCost(IEnumerable<IHarryPotterBook> books)
        {
            return books.Sum(b => b.price * b.count) * (decimal)0.9;
        }

        private static decimal GetTwoBookCost(IEnumerable<IHarryPotterBook> books)
        {
            return books.Sum(b => b.count * b.price) * (decimal)0.95;
        }

        private static decimal GetOneBookCost(IEnumerable<IHarryPotterBook> books)
        {
            return books.Sum(b => b.count * b.price);
        }
    }
}
