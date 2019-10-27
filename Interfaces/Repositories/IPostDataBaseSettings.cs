namespace MVCdotNetProject.Interfaces.Repositories
{
    public interface IPostDatabaseSettings
    {
        string PostCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

