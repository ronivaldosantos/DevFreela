using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Aplication.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjecViewModel> GetAll(string query);
        ProjectDetailsViewModel GetById(int id);

    }
}
