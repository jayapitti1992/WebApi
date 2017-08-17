using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLayer;
using DataLayer.Model;

namespace WebTask.Controllers
{
    public class AuthorsController : ApiController
    {
        TaskEntities dbentity =  new TaskEntities();

        public IEnumerable<Author> Get()
        {
            return dbentity.Authors.ToList();
        } 
    }
}
