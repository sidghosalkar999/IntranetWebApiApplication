using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Zns.Intranet.WebApi.DAL;
using Zns.Intranet.WebApi.Data;
using Zns.Intranet.WebApi.Models;

namespace Zns.Intranet.WebApi.Controllers
{
    public class TrainingsController : ApiController
    {
        //private ZnsIntranetWebApiContext db = new ZnsIntranetWebApiContext();
        ITrainingRepository _repo = new TrainingRepository(new ZnsIntranetWebApiContext());

        // GET: api/Trainings
        public IEnumerable<Trainer> GetTrainings()
        {
            return _repo.GetTrainings();
        }

        // GET: api/Trainings/5
        [ResponseType(typeof(Training))]
        public IHttpActionResult GetTraining(int id)
        {
            Training training = _repo.GetTraining(id);
            if (training == null)
            {
                return NotFound();
            }

            return Ok(training.GetType());
        }

        // PUT: api/Trainings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTraining(int id, Training training)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != training.TrainingId)
            {
                return BadRequest();
            }

            //_repo.Entry(training).State = EntityState.Modified;

            try
            {
                _repo.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Trainings
        [ResponseType(typeof(Training))]
        public IHttpActionResult PostTraining(Training training)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //_repo.GetTrainings(training);
            _repo.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = training.TrainingId }, training);
        }

        // DELETE: api/Trainings/5
        [ResponseType(typeof(Training))]
        public IHttpActionResult DeleteTraining(int id)
        {
            Training training = db.Trainings.Find(id);
            if (training == null)
            {
                return NotFound();
            }

            //_repo.Trainings.Remove(training);
            _repo.SaveChanges();

            return Ok(training);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrainingExists(int id)
        {
            return db.Trainings.Count(e => e.TrainingId == id) > 0;
        }
    }
}