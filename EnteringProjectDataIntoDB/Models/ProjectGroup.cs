namespace EnteringProjectDataIntoDB.Models
{
    public class ProjectGroup
    {
        public ProjectGroup(List<Project> projects) 
        {
            Projects = projects;
        }

        List<Project> Projects { get; }
        public void Add(Project project) 
        {
            if (ProjectIsAvailable(project))
                Projects.Add(project);
            else
                throw new Exception("Такой проект уже существует");
        }
        public void Update(Project project) { }
        public void Remove(Project project) { }

        public void SortByPriority(int priority) 
        { 

        }
        public List<Project> FindByPriority(int priority)
        {
            return Projects.FindAll(x => x.Priority == priority);
        }
        public bool ProjectIsAvailable(Project project)
        {
            int IdProject = Projects.IndexOf(project);
            if (IdProject != -1)
                return true;
            else
                return false;
        }
    }
}
