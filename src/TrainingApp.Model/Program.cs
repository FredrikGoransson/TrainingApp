using System.Collections.Generic;

namespace TrainingApp.Model
{
    public class Program : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Week> Weeks { get; set; }
    }
}