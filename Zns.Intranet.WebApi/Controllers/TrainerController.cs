using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zns.Intranet.WebApi.Models;

namespace Zns.Intranet.WebApi.Controllers
{
    public class TrainerController : ApiController
    {
        // GET: api/Trainer
        public IEnumerable<Trainer> Get()
        {
            return DbMemoryStore.lstTrainers.ToList();
        }

        // GET: api/Trainer/5
        public Trainer Get(int id)
        {
            return DbMemoryStore.lstTrainers.Where(t => t.Id == id).FirstOrDefault();
        }
        // GET: api/Trainer/5
        public IEnumerable<Trainer> Get(int id, string name, string TechnologyStack, int exp)
        {
            return DbMemoryStore.lstTrainers.Where(t => t.Id == id || t.Name.Contains(name) || t.TechnologyStack.Contains(TechnologyStack) || t.FieldExperience == exp).ToList();
        }

        // POST: api/Trainer
        public void Post(Trainer trainer)
        {
            DbMemoryStore.lstTrainers.Add(trainer);
        }

        // PUT: api/Trainer/5
        public void Put(int id, Trainer trainer)
        {
            var trainerFromDB = DbMemoryStore.lstTrainers.Find(t => t.Id == id);
            if (trainerFromDB != null)
                DbMemoryStore.lstTrainers.Remove(trainerFromDB);
            DbMemoryStore.lstTrainers.Add(trainer);
        }

        // DELETE: api/Trainer/5
        public void Delete(int id)
        {
            DbMemoryStore.lstTrainers.Remove(DbMemoryStore.lstTrainers.Find(t => t.Id == id));
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
