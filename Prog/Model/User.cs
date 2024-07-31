namespace Prog.Model
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Login { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role {  get; set; } = string.Empty;
        public List<TestInfo> Tests { get; set; }
        public List<Course> Courses { get; set; }

        public User()
        {
            Tests = new List<TestInfo>();
            Courses = new List<Course>();
        }
    }
}
