using MVCdotNetProject.Interfaces.Repositories;

namespace MVCdotNetProject.Repositories
{
    public class PostDatabaseSettings : IPostDatabaseSettings
    {
        public string PostCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
