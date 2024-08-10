using DotaCounterPicker.Data.DTO;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.PostgreSQL;
using LinqToDB.Mapping;

namespace Persistence;

public class PostgresDatabaseContext : DataConnection
{
    public PostgresDatabaseContext(string connectionString, MappingSchema mapping) : base(PostgreSQLTools.GetDataProvider(PostgreSQLVersion.v95), connectionString, mapping)
    {

    }

    public ITable<Hero> Heroes => this.GetTable<Hero>();

    public ITable<Line> Lines => this.GetTable<Line>();

    public ITable<HeroToLine> HeroToLines => this.GetTable<HeroToLine>();

}
