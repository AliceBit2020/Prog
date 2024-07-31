namespace Prog.Model
{
    public class TestInfo
    {
        public Guid  Id { get; set; }=Guid.NewGuid();
        public Theme Theme { get; set; } 
        public Course? Course { get; set; } 
        public DateTime Date_ {  get; set; }=DateTime.Now;
        public string Result { get; set; } = string.Empty;
        public TestInfo(Theme Theme_, Course Course_)
        {
            Theme = Theme_;
            Course = Course_;
        }
        public TestInfo()
        {
            Theme = new Theme();
            Course = new Course();
        }
    }
}
