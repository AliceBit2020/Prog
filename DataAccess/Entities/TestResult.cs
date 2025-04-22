namespace DataAccess.Entities
{
    public class TestResult
    {
        public Guid  Id { get; set; }=Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public string Result { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public Guid ThemeId { get; set; }
        public Guid CourseId { get; set; }
        public  User? User { get; set; }
        public Theme? Theme { get; set; }     
        public Course? Course { get; set; }  
    

     

    }
}
