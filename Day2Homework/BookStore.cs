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
            buyList = buyList.OrderBy(x => x.BookId).ToList();
            var differentBookCount = 0;
            double discount = 1;
            double totalPrice = 0;
            int? tempId = null;

            foreach (var book in buyList)
            {
                if (book.BookId != tempId)
                {
                    differentBookCount++;
                }
                else
                {
                    tempId = book.BookId;
                }
                tempId = book.BookId;

            }

            if (differentBookCount == 2)
                discount = 0.95;
            else if (differentBookCount == 3)
                discount = 0.9;
            else if (differentBookCount == 4)
                discount = 0.8;
            else if (differentBookCount == 5)
                discount = 0.75;

            for (int i = 0; i < buyList.Count; i++)
            {
                if (i <= differentBookCount - 1)
                {
                    totalPrice = totalPrice + buyList[i].Price * discount;
                }
                else
                    totalPrice = totalPrice + buyList[i].Price;
            }

            return totalPrice;
        }
    }
}