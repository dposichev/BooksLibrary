using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Etities
{
    public class BookGenre
    {
        public int BookId { get; set; }

        public Book Book { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
