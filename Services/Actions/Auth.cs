using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using Services.Models;
using System.Data;

namespace Services.Actions
{
    public class Auth
    {
        DataTierEntities dt = new DataTierEntities();

        List<Author> authlist = new List<Author>();
        List<LocalAuthor> Locallist = new List<LocalAuthor>();
        private LocalAuthor OneAuth;

        public IEnumerable<LocalAuthor> GetAllAuthors()
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
        public LocalAuthor GetByName(string id)
        {
            priauth = dt.Authors.FirstOrDefault(x => x.Name == id);

            OneAuth = new LocalAuthor();
            OneAuth.AuthId = priauth.Id;
            OneAuth.AuthName = priauth.Name;
            OneAuth.AuthPhoneNumber = priauth.PhoneNumber;
            OneAuth.AuthEmailAddress = priauth.EmailAddress;

            return OneAuth;


        }

        public void AddAuthor(LocalAuthor UserAuthor)
        {
            DataTier.Author DataAuthor = new DataTier.Author();
            DataAuthor.Id = UserAuthor.AuthId;
            DataAuthor.Name = UserAuthor.AuthName;
            DataAuthor.EmailAddress = UserAuthor.AuthEmailAddress;
            DataAuthor.PhoneNumber = UserAuthor.AuthPhoneNumber;
            dt.Authors.Add(DataAuthor);
            dt.SaveChanges();

        }

        public void EditAuthor(string _AuthId,LocalAuthor UserAuthor)
        {
            priauth = dt.Authors.FirstOrDefault(x => x.Id == _AuthId);

            dt.Authors.Remove(priauth);
            dt.SaveChanges();
            Author ppriauth = new Author(); 
            ppriauth.Id = UserAuthor.AuthId ;
             ppriauth.Name = UserAuthor.AuthName ;
             ppriauth.PhoneNumber = UserAuthor.AuthPhoneNumber ;
             ppriauth.EmailAddress = UserAuthor.AuthEmailAddress;
            dt.Authors.Add(ppriauth);
            dt.SaveChanges();

        }


        public void DeleteAuthor(string _id)
        {
            priauth = dt.Authors.FirstOrDefault(x => x.Id == _id);

            dt.Authors.Remove(priauth);
            dt.SaveChanges();
        }

    }
}
