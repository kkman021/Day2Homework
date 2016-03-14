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

        [TestMethod()]
        public void CountSumSellPrice_buy_no1_1_no2_1_no3_1_shoudl_price_270()
        {
            var buyList = new List<Book>
            {
                new Book() { BookId = 1, BookName = "哈利波特第一集", Price = 100 },
                new Book() { BookId = 2, BookName = "哈利波特第二集", Price = 100 },
                new Book() { BookId = 3, BookName = "哈利波特第三集", Price = 100 }
            };

            var expectPrice = 270;
            var target = new BookStore();

            var actual = target.CountSum(buyList);

            Assert.AreEqual(expectPrice, actual);
        }

        [TestMethod()]
        public void CountSumSellPrice_buy_no1_1_no2_1_no3_1__no4_1_shoudl_price_320()
        {
            var buyList = new List<Book>
            {
                new Book() { BookId = 1, BookName = "哈利波特第一集", Price = 100 },
                new Book() { BookId = 2, BookName = "哈利波特第二集", Price = 100 },
                new Book() { BookId = 3, BookName = "哈利波特第三集", Price = 100 },
                new Book() { BookId = 4, BookName = "哈利波特第四集", Price = 100 }

            };

            var expectPrice = 320;
            var target = new BookStore();

            var actual = target.CountSum(buyList);

            Assert.AreEqual(expectPrice, actual);
        }

        [TestMethod()]
        public void CountSumSellPrice_buy_no1_1_no2_1_no3_1__no4_1_no5_1_shoudl_price_375()
        {
            var buyList = new List<Book>
            {
                new Book() { BookId = 1, BookName = "哈利波特第一集", Price = 100 },
                new Book() { BookId = 2, BookName = "哈利波特第二集", Price = 100 },
                new Book() { BookId = 3, BookName = "哈利波特第三集", Price = 100 },
                new Book() { BookId = 4, BookName = "哈利波特第四集", Price = 100 },
                new Book() { BookId = 5, BookName = "哈利波特第五集", Price = 100 }
            };

            var expectPrice = 375;

            var target = new BookStore();

            var actual = target.CountSum(buyList);

            Assert.AreEqual(expectPrice, actual);
        }

        [TestMethod()]
        public void CountSumSellPrice_buy_no1_1_no2_1_no3_2_shoudl_price_370()
        {
            var buyList = new List<Book>
            {
                new Book() { BookId = 1, BookName = "哈利波特第一集", Price = 100 },
                new Book() { BookId = 2, BookName = "哈利波特第二集", Price = 100 },
                new Book() { BookId = 3, BookName = "哈利波特第三集", Price = 100 },
                new Book() { BookId = 3, BookName = "哈利波特第三集", Price = 100 }
            };

            var expectPrice = 370;

            var target = new BookStore();

            var actual = target.CountSum(buyList);

            Assert.AreEqual(expectPrice, actual);
        }
    }
}