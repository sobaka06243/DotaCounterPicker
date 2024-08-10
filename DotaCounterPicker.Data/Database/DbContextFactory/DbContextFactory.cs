using LinqToDB.Mapping;
using Microsoft.Extensions.Options;
using Persistence.Configurations;
using Persistence.Utils;

namespace Persistence.Database.DbContextFactory
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly IOptions<PostgresDatabaseOptions> _postgresOptions;
        private readonly MappingSchema _postgresMapping;

        public DbContextFactory(IOptions<PostgresDatabaseOptions> postgresOptions)
        {
            _postgresOptions = postgresOptions;
            _postgresMapping = DbMapping.Configure();
        }

        public PostgresDatabaseContext Create()
        {
            return new PostgresDatabaseContext(ConnectionFactory.CreatePostgresConnection(_postgresOptions.Value), _postgresMapping);
        }
    }
}