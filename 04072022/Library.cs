using System;
using System.Collections.Generic;
using System.Text;

namespace _04072022
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public  List<Book>Books=new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public Book GetBookById(int id)
        {
            return Books.Find(x => x.Id == id);
        }
        public void RemoveBook(int? id)
        {
            var result=Books.Find(x => x.Id == id);
            if (id==null)
            {
                throw new NullReferenceException("Null daxil edilib");
            }
            Books.Remove(result);
        }
    }
}
