namespace DataAccess.Entities
{
    public class Theme
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid CourseId { get; set; }
        public  Course? Course { get; set; } 
        public virtual IEnumerable<Question>? Questions { get; set; } 
        public virtual IEnumerable<TestResult>? Results{ get; set; }

       
       
       
    }
}
