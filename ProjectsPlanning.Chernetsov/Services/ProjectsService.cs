﻿using Microsoft.EntityFrameworkCore;
using ProjectsPlanning.Chernetsov.Data;
using ProjectsPlanning.Chernetsov.Entities;

namespace ProjectsPlanning.Chernetsov.Services
{
    public class ProjectsService : IProjectsService
    {
        private readonly ApplicationDbContext _context;
        public ProjectsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddProject(Project newProject)
        {
            _context.Projects.Add(newProject);
            _context.SaveChanges();
        }

        public void DeleteProject(int idProject)
        {
            var project = _context.Projects
                .Where(p => p.Id == idProject)
                .FirstOrDefault();
            project.IsDeleted = true;
            _context.SaveChanges();
        }

        public Project GetProject(string projectName)
        {
            return _context.Projects
                .Where(p => p.Name == projectName && p.IsDeleted == false)
                .FirstOrDefault();
        }

        public IEnumerable<Project> GetProjectsSortIdOne()
        {
            return _context.Projects
                .Where(pr => pr.IsDeleted == false && pr.StatusId == 1)
                .Include(pr => pr.Priority)
                .Include(pr => pr.Team)
                .ToList();
        }

        public IEnumerable<Project> GetProjectsSortIdTwo()
        {
            return _context.Projects
                .Where(pr => pr.IsDeleted == false && pr.StatusId == 2)
                .Include(pr => pr.Priority)
                .Include(pr => pr.Team)
                .ToList();
        }


        public IEnumerable<Project> GetProjectsSortIdThree()
        {
            return _context.Projects
                .Where(pr => pr.IsDeleted == false && pr.StatusId == 3)
                .Include(pr => pr.Priority)
                .Include(pr => pr.Team)
                .ToList();
        }

     
        public void UpdateProject(int id, Project newProject)
        {
            var project = _context.Projects
                 .Where(pr => pr.Id == id)
                 .FirstOrDefault();
            project.IsDeleted = true;

            _context.Projects.Add(newProject);
            _context.SaveChanges();
        }
        public Project GetProjectById(int id)
        {
            return _context.Projects
                 .Where(p => p.Id == id && p.IsDeleted == false)
                 .Include(pr => pr.Priority)
                 .Include(pr => pr.Team)
                 .FirstOrDefault();
        }
    }
}
