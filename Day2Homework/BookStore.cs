using System.Collections.Generic;
using System.Linq;

namespace Day2Homework
{
    public class BookStore
    {
        public BookStore()
        {
        }

        public int CountSum(List<Book> buyList)
        {
            return buyList.Sum(x => x.Price);
        }
    }
}