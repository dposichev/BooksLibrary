using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Etities
{
    /// <summary>
    /// Сущность жанра книги
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название жанра
        /// </summary>
        public int Name { get; set; }

        public List<BookGenre> BookGenres { get; set; }

        public Genre()
        {
            BookGenres = new List<BookGenre>();
        }
    }
}
