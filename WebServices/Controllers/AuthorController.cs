using Services.Actions;
using Services.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace WebServices.Controllers
{
    public class AuthorController : ApiController
    {
        private Auth authActions;
        public IEnumerable<Services.Models.LocalAuthor> Get()
        {
           authActions = new Auth();
            return authActions.GetAllAuthors();
        }

        
        public LocalAuthor Get(string id)
        {

            authActions = new Auth();
            return authActions.GetByName(id);

        }

        public void Post([FromBody] LocalAuthor val)
        {
            authActions = new Auth();
            authActions.AddAuthor(val);
        }

        public void Put(string id ,[FromBody] LocalAuthor LcAu)
        {

            authActions = new Auth();
            authActions.EditAuthor(id,LcAu);

        }

        public void Delete(string id)
        {
            authActions = new Auth();
            authActions.DeleteAuthor(id);
        }

    
}
}
