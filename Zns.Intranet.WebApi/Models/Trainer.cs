using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zns.Intranet.WebApi.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldExperience { get; set; }
        private string Technologies { get; set; } = string.Empty;
        public IList<string> TechnologyStack
        {
            get { return Technologies.Split(',').ToList(); }

            set { Technologies = string.Join(",", value); }
        }
       
        //[Newtonsoft.Json.JsonIgnore]
        //public bool IsActive { get; set; }
        //public ICollection<Training> Trainings { get; set; } = new List<Training>();
    }
    public class Training
    {
        [Key]
        public int TrainingId { get; set; }

        [ForeignKey("CourseTrainer")]
        public int TrainerId { get; set; }
        public string Title { get; set; }
        public string Description{ get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public virtual Trainer CourseTrainer { get; set; }
    }

    public static class DbMemoryStore
    {
        public static List<Trainer> lstTrainers = new List<Trainer>()
        {
            new Trainer(){Id=1, Name="Sid", FieldExperience=5, TechnologyStack= new List<string>() {".net","Java" } },
            new Trainer(){Id=2, Name="Viv", FieldExperience=6, TechnologyStack= new List<string>() {"Python","Mvc" } },
            new Trainer(){Id=3, Name="Ani", FieldExperience=7, TechnologyStack= new List<string>() {"Api","Entity Framework" } },
        };
    }
}