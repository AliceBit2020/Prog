namespace DataAccess.Entities
{
    public class Course
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; }=string.Empty;
        public string? Description { get; set; }
        public virtual IEnumerable<Theme>? Themes { get; set; }
        public virtual IEnumerable<User>? Users { get; set; }
        public virtual IEnumerable<Question>? Questions { get; set; }
        public virtual IEnumerable<TestResult>? Results { get; set; }

        
    }
}
