using System;

namespace FreakStreet.Interfaces
{
    public interface IMovieStoreDatabaseSettings
    {
        string MoviesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
