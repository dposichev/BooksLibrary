using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Etities
{
    /// <summary>
    /// Сущность книги
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор книги
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование книги
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Год издания книги
        /// </summary>
        public int Year { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }

        public List<BookGenre> BookGenres { get; set; }

        public Book()
        {
            BookAuthors = new List<BookAuthor>();
            BookGenres = new List<BookGenre>();
        }
    }
}
