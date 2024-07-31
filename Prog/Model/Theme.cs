namespace Prog.Model
{
    public class Theme
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        public Course? Course { get; set; }
        public string Description { get; set; } = string.Empty;
        public Theme(Course course)
        {
            Course = course;
        }
        public Theme()
        {
            Course = null;
        }
    }
}
