using System.Collections.Generic;
using System.Linq;

namespace Day2Homework
{
    public class BookStore
    {
        public BookStore()
        {
        }

        public double CountSum(List<Book> buyList)
        {
            double totalPrice = 0;

            buyList = buyList.OrderBy(x => x.BookId).ToList();

            var source = new List<Book>(buyList);

            var bookGroup = new List<List<Book>>();

            while (bookGroup.Sum(l => l.Distinct().Count()) < source.Count)
            {
                var list = new List<Book>();
                int? tempId = null;

                foreach (var book in buyList.ToArray())
                {
                    if (tempId != book.BookId)
                    {
                        list.Add(book);
                        buyList.Remove(book);
                    }
                    tempId = book.BookId;
                }
                bookGroup.Add(list);
            }


            foreach (var group in bookGroup)
            {
                totalPrice = totalPrice + group.Sum(x => x.Price) * GetDisCount(group.Count);
            }
            return totalPrice;
        }

        private static double GetDisCount(int bookCount)
        {
            double discount = 1;

            if (bookCount == 2)
                discount = 0.95;
            else if (bookCount == 3)
                discount = 0.9;
            else if (bookCount == 4)
                discount = 0.8;
            else if (bookCount == 5)
                discount = 0.75;

            return discount;
        }
    }
}