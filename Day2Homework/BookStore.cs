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
            double totalPrice = buyList.Sum(x => x.Price);
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
                totalPrice = totalPrice * 0.95;
            else if (differentBookCount == 3)
                totalPrice = totalPrice * 0.9;
            else if (differentBookCount == 4)
                totalPrice = totalPrice * 0.8;
            else if (differentBookCount == 5)
                totalPrice = totalPrice * 0.75;

            return totalPrice;
        }
    }
}