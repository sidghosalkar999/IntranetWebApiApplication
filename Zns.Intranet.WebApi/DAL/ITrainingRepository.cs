using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zns.Intranet.WebApi.Models;

namespace Zns.Intranet.WebApi.DAL
{
    interface ITrainingRepository
    {
        IEnumerable<Trainer> GetTrainings();
        Training GetTraining(int id);
        Training UpdateTraining(Training training);
        Training DeleteTraining(int id);
        Training CreateTraining(Training training);
        void SaveChanges();
    }
}
