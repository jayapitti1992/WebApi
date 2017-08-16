using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace Sevices.Services
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();
        Author GetAuthor(string id);

    }
}
