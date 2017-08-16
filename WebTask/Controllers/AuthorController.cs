using DataLayer.Model;
using Sevices.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace WebTask.Controllers
{
    public class AuthorController : ApiController
    {
        private  IAuthorService authorService = new AuthorService();

        public IEnumerable<Author> Get()
        {
            return authorService.GetAuthors();
        }

        public Author Get(string id)
        {
            return authorService.GetAuthor(id);
        }
    }
}
