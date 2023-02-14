namespace MyWebAPI.Models
{
    public class PersonDatabaseSetting : IPersonDatabaseSetting
    {
        public string ConnectionString { get; set; }="";
        public string Database { get; set; } = "";
        public string Collection { get; set; } = "";
    }
}
