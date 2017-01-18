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
        public void GetCostTest_1本第1集_100元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 1 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 100;
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

        [TestMethod()]
        public void GetCostTest_1本第1_2_3集_270元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 1 },
                new HarryPotterBook2 { count = 1 },
                new HarryPotterBook3 { count = 1 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 270;
            var actual = target.GetCost(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCostTest_1本第1_2_3_4集_320元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 1 },
                new HarryPotterBook2 { count = 1 },
                new HarryPotterBook3 { count = 1 },
                new HarryPotterBook4 { count = 1 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 320;
            var actual = target.GetCost(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCostTest_1本第1_2_3_4_5集_375元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 1 },
                new HarryPotterBook2 { count = 1 },
                new HarryPotterBook3 { count = 1 },
                new HarryPotterBook4 { count = 1 },
                new HarryPotterBook5 { count = 1 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 375;
            var actual = target.GetCost(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCostTest_1本第1_2集_2本第3集_370元()
        {
            List<IHarryPotterBook> books = new List<IHarryPotterBook> {
                new HarryPotterBook1 { count = 1 },
                new HarryPotterBook2 { count = 1 },
                new HarryPotterBook3 { count = 2 }
            };
            HarryPotter target = new HarryPotter();

            decimal expected = 370;
            var actual = target.GetCost(books);

            Assert.AreEqual(expected, actual);
        }
    }
}