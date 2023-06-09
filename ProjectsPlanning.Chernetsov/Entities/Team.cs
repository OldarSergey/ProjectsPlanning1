﻿namespace ProjectsPlanning.Chernetsov.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
