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
            FiveBookCost bookCost = new FiveBookCost();
            return bookCost.GetCost(books);
        }

        private static decimal GetFourBookCost(IEnumerable<IHarryPotterBook> books)
        {
            FourBookCost bookCost = new FourBookCost();
            return bookCost.GetCost(books);
        }

        private static decimal GetThreeBookCost(IEnumerable<IHarryPotterBook> books)
        {
            ThreeBookCost bookCost = new ThreeBookCost();
            return bookCost.GetCost(books);
        }

        private static decimal GetTwoBookCost(IEnumerable<IHarryPotterBook> books)
        {
            TwoBookCost bookCost = new TwoBookCost();
            return bookCost.GetCost(books);
        }

        private static decimal GetOneBookCost(IEnumerable<IHarryPotterBook> books)
        {
            OneBookCost bookCost = new OneBookCost();
            return bookCost.GetCost(books);
        }
    }
}
