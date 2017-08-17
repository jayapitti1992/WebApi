using DataTier;
using Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Actions
{
    public class Book
    {
        DataTierEntities dt;
        List<DataTier.Book> booklist = new List<DataTier.Book>();
        List<LocalBook> Localbooks = new List<LocalBook>();
        private LocalBook OneBook;

        public IEnumerable<LocalBook> GetAllBooks()
        {
            dt = new DataTierEntities();
            booklist = dt.Books.ToList();

            foreach (var t in booklist)
            {
                OneBook = new Models.LocalBook();
                OneBook.Id = t.Id;
                OneBook.Name = t.Name;
                OneBook.AuthorId = t.AuthorId;
                OneBook.ISBN = t.ISBN;
                OneBook.PublishDate = t.PublishDate;

                Localbooks.Add(this.OneBook);

            }
            return Localbooks;


        }


        private DataTier.Book priauth;
        private Author priauth1;

        public LocalBook GetByBook(string id)
        {
            dt = new DataTierEntities();
            priauth1 = dt.Authors.ToList().FirstOrDefault(x => x.Name == id);


            priauth = dt.Books.ToList().FirstOrDefault(x => x.AuthorId == priauth1.Id);

            OneBook = new LocalBook();
            OneBook.Id = priauth.Id;
            OneBook.Name = priauth.Name;
            OneBook.AuthorId = priauth.AuthorId;
            OneBook.PublishDate = priauth.PublishDate;
            OneBook.ISBN = priauth.ISBN;
            return OneBook;
        }
    }
}
