namespace Persistence.Database.DbContextFactory;

public interface IDbContextFactory
{
    PostgresDatabaseContext Create();
}
