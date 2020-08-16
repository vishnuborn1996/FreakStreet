using System;
using System.Collections.Generic;
using System.Text;

namespace FreakStreet.Shared
{
    public class MovieModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrimaryImg { get; set; }
        public string PrimaryVid { get; set; }
    }
}
