using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Data.Etities;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private LibraryContext _libraryContext;

        public BookController()
        {
            _libraryContext = new LibraryContext();
        }

        [HttpGet]
        public JsonResult Get()
        {
            var books = _libraryContext.Books.ToList<Book>();

            return Json(books);
        }
    }
}
