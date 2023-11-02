using DevFreela.Aplication.InputModels;
using DevFreela.Aplication.ViewModels;


namespace DevFreela.Aplication.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjecViewModel> GetAll(string query);
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void CreateComment(CreateCommentInputModel inputModel);
        void Start(int id);
        void Finish(int id);   

    }
}
