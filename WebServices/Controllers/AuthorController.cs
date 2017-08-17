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
    public class AuthorController : ApiController
    {
        DataTierEntities dt = new DataTierEntities();

        List<Author> authlist = new List<Author>();
        List<LocalAuthor> Locallist = new List<LocalAuthor>();
        private LocalAuthor OneAuth;
        public IEnumerable<LocalAuthor> Get()
        {
            authlist = dt.Authors.ToList();

            foreach (Author t in authlist)
            {
                OneAuth = new LocalAuthor();
                OneAuth.AuthId = t.Id;
                OneAuth.AuthName = t.Name;
                OneAuth.AuthPhoneNumber = t.PhoneNumber;
                OneAuth.AuthEmailAddress = t.EmailAddress;
                Locallist.Add(this.OneAuth);

            }
            return Locallist;


        }

        private Author priauth;
        public LocalAuthor Get(string id)
        {
            priauth = dt.Authors.FirstOrDefault(x => x.Name == id);

            OneAuth = new LocalAuthor();
            OneAuth.AuthId = priauth.Id;
            OneAuth.AuthName = priauth.Name;
            OneAuth.AuthPhoneNumber = priauth.PhoneNumber;
            OneAuth.AuthEmailAddress = priauth.EmailAddress;

            return OneAuth;


        }
    
}
}
