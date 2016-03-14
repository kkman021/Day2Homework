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
    }
}