namespace Persistence.Configurations;

public class PostgresDatabaseOptions
{
    public string Host { get; set; }
    public int Port { get; set; }
    public string Name { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public int MaxPoolSize { get; set; }
    public int MinPoolSize { get; set; }
    public int KeepAlive { get; set; } = 300;
}
