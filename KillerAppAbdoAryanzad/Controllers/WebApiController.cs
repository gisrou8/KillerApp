using KillerAppAbdoAryanzad.Database;
using KillerAppAbdoAryanzad.Database.Repositories;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KillerAppAbdoAryanzad.Controllers
{
    public class WebApiController : ApiController
    {
        // GET api/<controller>
        public List<TypeDrugs> Get()
        {
            TypeDrugsRepo typedrugsrepo = new TypeDrugsRepo(new MSSQLTypeDrugsContext());
            List<TypeDrugs> typedrugs = typedrugsrepo.GetAll();
            return typedrugs;
            
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}