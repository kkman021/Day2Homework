using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day2Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2Homework.Tests
{
    [TestClass()]
    public class BookStoreTests
    {
        [TestMethod()]
        public void CountSumSellPrice_buy_no1_1_shoudl_price_100()
        {
            var buyList = new List<Book> { new Book() { BookId = 1, BookName = "哈利波特第一集", Price = 100 } };
            var expectPrice = 100;
            var target = new BookStore();

            var actual = target.CountSum(buyList);

            Assert.AreEqual(expectPrice, actual);
        }

        [TestMethod()]
        public void CountSumSellPrice_buy_no1_1_no2_1_shoudl_price_190()
        {
            var buyList = new List<Book>
            {
                new Book() { BookId = 1, BookName = "哈利波特第一集", Price = 100 },
                new Book() { BookId = 2, BookName = "哈利波特第二集", Price = 100 }
            };

            var expectPrice = 190;
            var target = new BookStore();

            var actual = target.CountSum(buyList);

            Assert.AreEqual(expectPrice, actual);
        }
    }
}