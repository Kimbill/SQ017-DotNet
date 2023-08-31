using DotnetLibrary.Data.Repositories.implementations;
using DotnetLibrary.Data.Repositories.Interfaces;
using System;

namespace DotNetLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();

            bookRepository.Add(new DotnetLibrary.Model.Book { Id = 1, Title = "OOP 1", Author = "Chinedu" });

            var firstBook = bookRepository.GetById(1);
            Console.WriteLine($"OOP 1: {firstBook.Title} by {firstBook.Author}");
        }
    }
}
