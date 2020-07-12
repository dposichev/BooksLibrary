using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Etities
{
    /// <summary>
    /// Сущность автора книги
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ФИО автора
        /// </summary>
        public String Name { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }

        public Author()
        {
            BookAuthors = new List<BookAuthor>();
        }
    }
}
