using MongoDB.Driver;

namespace MyWebAPI.Models
{
    public class PersonService : IPersonService
    {
        private readonly IMongoCollection<Person> _person;
        public PersonService(IPersonDatabaseSetting setting) 
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var database = mongoClient.GetDatabase("Persons");
            _person = database.GetCollection<Person>(setting.Collection);
        }
        public void Delete(string id)
        {
            _person.DeleteOne(Person=>Person.Id == id);
        }

        public List<Person> Get()
        {
            return _person.Find(Person=>true).ToList();
        }

        public Person Get(string id)
        {
            return _person.Find(Person=>Person.Id == id).FirstOrDefault();
        }

        public Person Post(Person person)
        {
            _person.InsertOne(person);
            return person;
        }

        public void Put(string id, Person person)
        {
            _person.ReplaceOne(person => person.Id == id,person);
        }
    }
}
