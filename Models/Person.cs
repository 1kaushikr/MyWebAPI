using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace MyWebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Person
    {
        public string Id { get; set; }="";

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("country")]
        public string? Country { get; set; }

        [BsonElement("annualIncome")]
        public double? AnnualIncome { get; set; }

        [BsonElement("EmailList")]
        public List<string>? EmailList { get; set; }
    }
}