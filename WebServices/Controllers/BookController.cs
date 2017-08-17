using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataTier;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class BookController : ApiController
    {
        DataTierEntities dt = new DataTierEntities();

        List<Book> authlist = new List<Book>();
        List<LocalBook> Locallist = new List<LocalBook>();
        private LocalBook OneAuth;
        public IEnumerable<LocalBook> Get()
        {
            authlist = dt.Books.ToList();

            foreach (Book t in authlist)
            {
                OneAuth = new LocalBook();
                OneAuth.Id = t.Id;
                OneAuth.Name = t.Name;
                OneAuth.AuthorId = t.AuthorId;
                OneAuth.ISBN = t.ISBN;
                OneAuth.PublishDate = t.PublishDate;

                Locallist.Add(this.OneAuth);

            }
            return Locallist;


        }
    }
}
