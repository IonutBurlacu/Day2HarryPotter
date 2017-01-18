using Microsoft.VisualStudio.TestTools.UnitTesting;
using HarryPotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarryPotter.Books;

namespace HarryPotter.Tests
{
    [TestClass()]
    public class HarryPotterTests
    {
        [TestMethod()]
        public void GetCostTest_3本第1集_300元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 3 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 300;
            var actual = target.GetCost(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCostTest_1本第1集_1本第2集_190元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 1 },
                new HarryPotterBook2 { count = 1 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 190;
            var actual = target.GetCost(books);

            Assert.AreEqual(expected, actual);
        }
    }
}