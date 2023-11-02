using DevFreela.Aplication.InputModels;
using DevFreela.Aplication.Services.Interfaces;
using DevFreela.Aplication.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastruture.Persistence;

namespace DevFreela.Aplication.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);

            _dbContext.Projects.Add(project);

            return project.Id;  
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdUser, inputModel.IdProject);
            _dbContext.projectComments.Add(comment);
        }

        public void Delete(int id)
        {
            var projects = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            projects.Cancel();
        }

        public List<ProjecViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;

            var projectViewModel = projects
                .Select(p => new ProjecViewModel(p.Id,p.Title,p.CreatedAt))
                .ToList();
            return projectViewModel;

        }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            if (project == null) return null;
            var projectDatailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.TotalCost,
                project.StartedAt,
                project.FinishedAt );

            return projectDatailsViewModel;
        }

        public void Start(int id)
        {
            var projects = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            projects.Start();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            var projects = _dbContext.Projects.SingleOrDefault(p => p.Id == inputModel.Id);
            projects.Update(inputModel.Title,inputModel.Description,inputModel.TotalCost);
        }

        public void Finish(int id)
        {
            var projects = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            projects.Finish();
        }

    }
}
