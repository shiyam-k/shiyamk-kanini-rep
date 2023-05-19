namespace Dependency_Injection_MVC_11_5_23.Models
{
    public class RepoDI : IRepoDI
    {
        private List<Projects> projects;
        public RepoDI()
        {
            projects = new List<Projects>()
            {
                new Projects() {ProjectId = "1", ProjectName ="Lambo"},
                new Projects() {ProjectId = "2",ProjectName="Alto"}
            };
        }

        public Projects AddProjects(Projects project)
        {
            project.ProjectId = projects.Max(x => x.ProjectId) + 1;
            projects.Add(project);
            return project;
        }

        public IEnumerable<Projects> GetProjects()
        {
            return projects;
        }
    }
}
