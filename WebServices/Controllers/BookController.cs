using Services.Actions;
using Services.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class BookController : ApiController
    {
        private Book bookActions;
        public IEnumerable<LocalBook> Get()
        {
            bookActions = new Book();
            return bookActions.GetAllBooks();

        }

        public LocalBook Get(string id)
        {
            bookActions = new Book();
            return bookActions.GetByBook(id);
        }

    }
}
