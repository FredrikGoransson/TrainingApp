using System.Collections.Generic;

namespace TrainingApp.Model
{
    public class Day : Entity
    {
        public int Number { get; set; }
        public string WeekDayName { get; set; }
        public ICollection<Excercise> Excercises { get; set; }
    }
}