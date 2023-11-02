
namespace DevFreela.Aplication.ViewModels
{
    public class ProjecViewModel
    {
        public ProjecViewModel(int id, string title, DateTime createAt)
        {   
            Id = id;
            Title = title;
            CreateAt = createAt;
        }
        public int Id { get; private set; }
        public string Title { get;private set; }
        public DateTime CreateAt { get; private set; }

    }
}
