namespace Dependency_Injection_MVC_11_5_23.Models
{
    public interface IRepoDI
    {
        Projects AddProjects(Projects car);

        IEnumerable<Projects> GetProjects();
    }
}
