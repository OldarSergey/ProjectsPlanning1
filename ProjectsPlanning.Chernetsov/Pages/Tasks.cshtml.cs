using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectsPlanning.Chernetsov.Entities;
using ProjectsPlanning.Chernetsov.Entities.DTO;
using ProjectsPlanning.Chernetsov.Services;

namespace ProjectsPlanning.Chernetsov.Pages
{
    public class TasksModel : PageModel
    {
        private readonly ILogger<TasksModel> _logger;
        private readonly IProjectsService _projectsService;
        private readonly ICategoryService _categoryService;
        private readonly ITeamService _teamService;

        [BindProperty]
        public InputTask Input { get; set; }
        public List<SelectListItem> TeamItems { get; set; }

        public TasksModel(ILogger<TasksModel> logger, IProjectsService projectsService, ICategoryService categoryService, ITeamService teamService)

        {
            _logger = logger;
            _projectsService = projectsService;
            _categoryService = categoryService;
            _teamService = teamService;
            LoadTeams();

        }
        private void LoadTeams()
        {
            List<Team> teams = _teamService.GetAllTeam();
            TeamItems = teams.Select(t => new SelectListItem
            {
                Value = "1",
                Text = t.Name
            })
           .ToList();
            TeamItems.Insert(0, new SelectListItem { Value = "0", Text = "�����������" });
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            var project = new Project
            {
                Name = Input.Name,

            };
            // �� ������ InputProject �������� ������ � ���������� Project � ������� �� ������� ����� Add
            return Page();
        }
    }
}