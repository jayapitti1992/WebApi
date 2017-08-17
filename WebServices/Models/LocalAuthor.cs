using System;
using System.Collections.Generic;
using DataTier;

namespace WebServices.Models
{
    public class LocalAuthor
    {
        public string AuthId { get; set; }
        public string AuthName { get; set; }
        public string AuthEmailAddress { get; set; }
        public string AuthPhoneNumber { get; set; }

    }

    public class LocalBook
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AuthorId { get; set; }
        public System.DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
    }


}
    