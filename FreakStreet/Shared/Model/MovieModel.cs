using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreakStreet.Shared
{
    [BsonIgnoreExtraElements]
    public class MovieModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        [BsonElement("id")]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("primaryImg")]
        public string PrimaryImg { get; set; }
        [BsonElement("primaryVid")]
        public string PrimaryVid { get; set; }
        [BsonElement("casts")]
        public List<CastModel> Casts { get; set; }
    }
}
