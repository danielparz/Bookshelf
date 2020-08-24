using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Bookshelf.Domain.Entity;
using Bookshelf.App.Concrete;
using System.IO;

namespace Bookshelf.Tests
{
    public class BookServiceUnitTest
    {
        [Fact]
        public void AddBookTest()
        {
            var author = new Author() { Id = 1, Firstname = "Adam", Lastname = "Mickiewicz" };
            var publisher = new PublishingHouse() { Id = 1, Name = "Głos" };
            var genres = new List<Genre>();
            var status = new Status() { Id = 1, Name = "Na półce" };

            var bookService = new BookService(@"C:\Programowanie\Bookshelf\Bookshelf\Data\Books.json");

            var bookId = bookService.AddBook("Pan Tadeusz", author, publisher, 300, 2010, genres, status);

            bookService.Items.Should().NotBeNull();
            bookId.Should().Be(1);

            File.Delete(@"C:\Programowanie\Bookshelf\Bookshelf\Data\Books.json");
        }
    }
}
