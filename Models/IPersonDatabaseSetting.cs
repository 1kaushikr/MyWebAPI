namespace MyWebAPI.Models
{
    public interface IPersonDatabaseSetting
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}
