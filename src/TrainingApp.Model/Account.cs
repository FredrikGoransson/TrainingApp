namespace TrainingApp.Model
{
    public class Account : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public User User { get; set; }
    }
}