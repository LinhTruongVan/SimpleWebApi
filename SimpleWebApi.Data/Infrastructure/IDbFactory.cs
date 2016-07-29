using System;

namespace SimpleWebApi.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SimpleWebApiContext Init();
    }
}
