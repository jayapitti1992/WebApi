using DataTier;

namespace Services.Models
{

    public class LocalBook
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string AuthorId { get; set; }
            public System.DateTime PublishDate { get; set; }
            public string ISBN { get; set; }
            public virtual Author Author { get; set; }
        }
    }

