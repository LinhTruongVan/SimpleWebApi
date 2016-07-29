namespace SimpleWebApi.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
