using DataLayer.Model;
using System.Collections.Generic;
using System.Linq;


namespace Sevices.Services
{
    public class AuthorService : IAuthorService
    {
        private TaskEntities db = new TaskEntities();

        public List<Author> GetAuthors()
        {
            return db.Authors.ToList();
        }

        public Author GetAuthor(string id)
        {
            return db.Authors.Where(x => x.Id == id).FirstOrDefault();
        }

        

    }
}