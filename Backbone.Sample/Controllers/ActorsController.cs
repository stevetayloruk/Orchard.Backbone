using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backbone.Sample.Models;
using Orchard.Data;
using Orchard.UI.Admin;

namespace Backbone.Sample.Controllers
{
    public class ActorsController : ApiController
    { 
        private readonly IRepository<ActorRecord> actorRepository;

        public ActorsController(IRepository<ActorRecord> actorRepository)
        {
             this.actorRepository = actorRepository; 
        }

        // GET api/<controller>
        public IEnumerable<ActorRecord> Get()
        {
            return actorRepository.Table.ToList();
        }

        // GET api/<controller>/5
        public ActorRecord Get(int id)
        {
            return actorRepository.Get(id);
        }

        #region Other CRUD

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

        #endregion
    }
}