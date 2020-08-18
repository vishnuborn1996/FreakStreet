using FreakStreet.Interfaces;
using System;

namespace FreakStreet.Model
{
    public class MovieStoreDatabaseSettings: IMovieStoreDatabaseSettings
    {
        public string MoviesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
