using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Etities
{
    /// <summary>
    /// Сущность для связи книги с авторами
    /// </summary>
    public class BookAuthor
    {
        /// <summary>
        /// Идентификатор книги
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Свойство навигации по ссылке
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Свойство навиганции по ссылке
        /// </summary>
        public Author Author { get; set; }
    }
}
