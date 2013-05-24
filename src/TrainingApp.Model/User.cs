using System.Collections.Generic;

namespace TrainingApp.Model
{
    public class User : Entity
    {
        public double OneRepMaxSquat { get; set; }
        public double OneRepMaxBench { get; set; }
        public double OneRepMaxDeadlift { get; set; }
    }
}