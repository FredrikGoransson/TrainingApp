namespace TrainingApp.Model
{
    public class Excercise : Entity
    {
        public int Repetitions { get; set; }
        public int Sets { get; set; }
        public double Weight { get; set; }
    }
}