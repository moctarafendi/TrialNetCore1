using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialNetCore1.IService;
using TrialNetCore1.Models;

namespace TrialNetCore1.Service
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books;
        public BookRepository()
        {
            if (_books == null)
            {
                InitializeBooks();
            }
        }

        private void InitializeBooks()
        {
            _books = new List<Book>()
            {
                new Book
                {
                    Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile",
                    Penulis = "Junindar",
                    Deskripsi = "",
                    Status = true,
                    Gambar = "/images/gambar1.jpg"
                },
                new Book
                {
                    Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 2",
                    Penulis = "Junindar",
                    Deskripsi = "",
                    Status = true,
                   Gambar = "/images/gambar2.jpg"
                },
                new Book
                {
                    Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 3",
                    Penulis = "Junindar",
                    Deskripsi = "",
                    Status = true,
                     Gambar = "/images/gambar3.jpg"
                },
                new Book
                {
                    Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 4",
                    Penulis = "Junindar",
                    Deskripsi = "",
                    Status = true,
                     Gambar = "/images/gambar4.jpg"
                },
                new Book
                {
                    Judul = "XAMARIN ANDROID - Mudah Membangun Aplikasi Mobile 5",
                    Penulis = "Junindar",
                    Deskripsi = "",
                    Status = true,
                     Gambar = "/images/gambar5.jpg"
                },
            };
        }

        IEnumerable<Book> IBookRepository.GetAllBooks()
        {
            return _books;
        }

        Book IBookRepository.GetBookById(int bookId)
        {
            return new Book();
        }

    }

}
