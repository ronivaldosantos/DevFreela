using DevFreela.Aplication.InputModels;
using DevFreela.Aplication.Services.Interfaces;
using DevFreela.Aplication.ViewModels;
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
            throw new NotImplementedException();
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Finish(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjecViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Start(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateProjectInpModel inpModel)
        {
            throw new NotImplementedException();
        }
    }
}
