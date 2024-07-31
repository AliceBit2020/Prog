﻿namespace Prog.Model
{
    public class Course
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }= string.Empty;
        public List<Theme> Themes { get; set; }

        public Course()
        {
            Themes = new List<Theme>();
        }
    }
}
