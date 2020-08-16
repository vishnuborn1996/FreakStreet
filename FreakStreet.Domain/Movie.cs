using System;

namespace FreakStreet.Domain
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime YearOfRelease { get; set; }
    }
}
