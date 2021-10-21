using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Zns.Intranet.WebApi.Models;
using Zns.Intranet.WebApi.Data;
using Zns.Intranet.WebApi.Controllers;

namespace Zns.Intranet.WebApi.DAL
{
    public class TrainingRepository : ITrainingRepository
    {
        private ZnsIntranetWebApiContext _db;

        public TrainingRepository(ZnsIntranetWebApiContext db)
        {
            _db = db;
        }

        public void CreateTraining(Training training)
        {
            _db.Trainings.Add(training);
            _db.SaveChanges();
        }

        public void DeleteTraining(int id)
        {
            //_db.Trainings.Remove(Training);
            _db.SaveChanges();
            throw new NotImplementedException();
        }
        public void GetTraining(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Trainer> GetTrainings()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public Training UpdateTraining(Training training)
        {
            throw new NotImplementedException();
        }

        Training ITrainingRepository.CreateTraining(Training training)
        {
            throw new NotImplementedException();
        }

        Training ITrainingRepository.DeleteTraining(int id)
        {
            throw new NotImplementedException();
        }

        Training ITrainingRepository.GetTraining(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}