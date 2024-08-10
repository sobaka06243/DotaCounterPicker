using Npgsql;
using Persistence.Configurations;

namespace Persistence.Utils;

public static class ConnectionFactory
{
    public static string CreatePostgresConnection(PostgresDatabaseOptions options)
    {
        var connStringBuilder = CreateConnection(options);

        if (options.MaxPoolSize > 0)
        {
            connStringBuilder.MaxPoolSize = options.MaxPoolSize;
        }

        if (options.MinPoolSize > 0)
        {
            connStringBuilder.MinPoolSize = options.MinPoolSize;
        }

        return connStringBuilder.ToString();
    }

    public static string CreateHangfireConnection(PostgresDatabaseOptions options)
    {
        return CreateConnection(options).ToString();
    }

    private static NpgsqlConnectionStringBuilder CreateConnection(PostgresDatabaseOptions options)
    {
        return new NpgsqlConnectionStringBuilder()
        {
            Host = options.Host,
            Port = options.Port,
            Database = options.Name,
            Username = options.User,
            Password = options.Password,
            KeepAlive = options.KeepAlive,
        };
    }
}
