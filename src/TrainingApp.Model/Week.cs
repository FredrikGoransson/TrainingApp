using System.Collections.Generic;

namespace TrainingApp.Model
{
    public class Week : Entity
    {
        public int Number { get; set; }
        public bool IsRecurring { get; set; }

        public ICollection<Day> Days { get; set; }
    }
}
