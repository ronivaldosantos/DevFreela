using DevFreela.Core.Entities;

namespace DevFreela.Infrastruture.Persistence {

    public class DevFreelaDbContext 
    {
        public DevFreelaDbContext()
        {
            //Inicializando projetos ficticios para testes
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1","Minha descrição do projeto 1",1,1,10000),
                new Project("Meu projeto ASPNET Core 2","Minha descrição do projeto 2",1,1,20000),
                new Project("Meu projeto ASPNET Core 3","Minha descrição do projeto 3",1,1,30000)
            };

            //Inicializando usuários fictícios para testes
            Users = new List<User>
            {
                new User("Ronivaldo","ronivaldo@teste.com.br",new DateTime(1971,1,20)),
                new User("Regina","regina@teste.com.br",new DateTime(1964,4,23)),
                new User("Barbara","barbara@teste.com.br",new DateTime(1997,6,7))
            };

            //Inicializando habildades fictícias para testes
            Skills = new List<Skill>
            {
                new Skill(".NET CORE"),
                new Skill("C#"),
                new Skill("SQL")
            };

        }
        public List<Project> Projects { get;  set; }
        public List<User> Users { get;  set; }
        public List<Skill> Skills { get;  set; }

    }
}
