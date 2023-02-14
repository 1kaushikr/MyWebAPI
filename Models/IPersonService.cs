namespace MyWebAPI.Models
{
    public interface IPersonService
    {
        List<Person> Get();
        Person Get(string id);
        Person Post(Person person);
        void Put(string id, Person person);
        void Delete(string id);
    }
}
