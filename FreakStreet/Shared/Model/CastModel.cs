using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreakStreet.Shared
{
    [BsonIgnoreExtraElements]
    public class CastModel
    {
        [BsonElement("id")]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("characterName")]
        public string CharacterName { get; set; }

    }
}
