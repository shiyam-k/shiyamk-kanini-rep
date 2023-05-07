using API_test__03_05_23.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_test__03_05_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        public readonly LibraryContext libraryContext;
        public LibraryController(LibraryContext libraryContext)
        {
            this.libraryContext = libraryContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Library>> GetLibraryDetails()
        {
            if(libraryContext == null)
            {
                
            }

            return libraryContext.Library.ToList();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Library>> GetLibraryDetailsById(int id)
        {
            if(libraryContext == null)
            {
                return NotFound();
            }
            Library book = libraryContext.Library.Find(id);
            if(book == null)
            {
                return NotFound();
            }
            return book;
        }
        [HttpPost]
        public async Task<ActionResult<string>> Postbook(LibraryPost newBook)
        {
            if(libraryContext == null)
            {
                return NotFound();
            }
            Library bookToBeAdded = new Library()
            {
                BookAuthor = newBook.BookAuthor,
                BookName = newBook.BookName,
                BookGenre= newBook.BookGenre,
                BookPublishers= newBook.BookPublishers,
                PublishedYear= newBook.PublishedYear,
                BookPrice= newBook.BookPrice,
            };
            await libraryContext.Library.AddAsync(bookToBeAdded);
            await libraryContext.SaveChangesAsync();
            return "Added";
        }
        [HttpPut]
        public async Task<string> PutBook(int id, LibraryPost updateBook)
        {
            if(libraryContext==null)
            {
                return "Not Found";
            }
            Library book = libraryContext.Library.Find(id);
            if(book != null)
            {
                book.BookAuthor = updateBook.BookAuthor;
                book.BookName = updateBook.BookName;
                book.BookGenre = updateBook.BookGenre;
                book.BookPublishers = updateBook.BookPublishers;
                book.PublishedYear = updateBook.PublishedYear;
                book.BookPrice = updateBook.BookPrice;
                libraryContext.Library.Update(book);
                await libraryContext.SaveChangesAsync();
                return "Updated";
            }
           return "Not Found";
        }
    }
}
