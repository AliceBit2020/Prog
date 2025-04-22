namespace DataAccess.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Login { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role {  get; set; } = string.Empty;
        public virtual IEnumerable<TestResult>? TestResults { get; set; }
        public virtual IEnumerable<Course>?  Courses { get; set; }
        
    }
}
