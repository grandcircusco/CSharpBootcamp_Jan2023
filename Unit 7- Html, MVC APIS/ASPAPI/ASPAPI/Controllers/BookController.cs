using ASPAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace ASPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //Pretend this is a SQL Database
        List<Book> bookDB = new List<Book>()
        {
            new Book("Legends and Lattes", "Fantasy", 2022),
            new Book("How to Win Friends and Influence Others", "Fantasy", 2000),
            new Book("Sherlock Holmes", "Classic", 1887),
            new Book("A Song of Ice and Fire", "Fantasy", 1996),
            new Book("One Hundred Years of Solitude", "Fiction", 1967),
            new Book("You're Gonna Die: A Framework for Happiness","Self Help",2020),
            new Book("Diary of a Wimpy Kid", "Adventure", 2011),
            new Book("The Lord of the Rings: The Two Towers", "Fantasy", 1954),
            new Book ("Brain on Fire", "Autobiography", 2012),
            new Book("C++ All-in-One Desk Reference For Dummies", "Educational", 2003),
            new Book("Brave New World", "Science Fiction", 1932)
        };


        //Get is for retreiving
        //api/book
        [HttpGet]
        public List<Book> GetAll() //Name of the method doesn't matter
        {
            return bookDB;
        }

        //api/book/title?t=Sherlock Holmes
        [HttpGet("title")]
        public Book GetByTitle(string t)
        {
            return bookDB.FirstOrDefault(b => b.Title.Contains(t));
        }

        //api/book/Fantasy
        //api/book/Fiction
        [HttpGet("{Category}")]
        public List<Book> GetByCategory(string Category)
        {
            return bookDB.Where(b => b.Category == Category).ToList();
        }

        //Post is for adding
        //api/book?title=Harry Potter&category=Fantasy&year=1996
        [HttpPost]
        public Book AddBook(string title, string category, int year)
        {
            Book newBook = new Book(title, category, year);
            bookDB.Add(newBook);

            return newBook;//Common practice to return new object
        }

        //Delete is for delete
        //api/book?title=Sherlock Holmes
        [HttpDelete]
        public Book DeleteBook(string title)
        {
            Book b = bookDB.FirstOrDefault(b => b.Title == title);
            bookDB.Remove(b);

            return b;
        }

        //Put or Patch is for updating
        [HttpPut]
        public Book UpdateBook(string oldTitle, string newTitle)
        {
            Book b = bookDB.FirstOrDefault(b=> b.Title == oldTitle);
            b.Title = newTitle;

            return b;
        }
    }
}
