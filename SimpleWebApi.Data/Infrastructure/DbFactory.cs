namespace SimpleWebApi.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SimpleWebApiContext dbContext;

        public SimpleWebApiContext Init()
        {
            return dbContext ?? (dbContext = new SimpleWebApiContext());
        }

        protected override void DisposeCore()
        {
            dbContext?.Dispose();
        }
    }
}
