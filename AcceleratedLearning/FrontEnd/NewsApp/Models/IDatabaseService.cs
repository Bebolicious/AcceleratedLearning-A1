namespace NewsApp.Models
{
    public interface IDatabaseService
    {
        void ClearAll();
        void RecreateDatabase();
        void SeedRepo();
    }
}