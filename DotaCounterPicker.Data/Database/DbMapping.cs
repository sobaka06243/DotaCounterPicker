using DotaCounterPicker.Data.DTO;
using LinqToDB.Mapping;
namespace Persistence.Database;

public class DbMapping
{
    public static MappingSchema Configure()
    {
        var builder = new FluentMappingBuilder();

        builder.Entity<Hero>()
            .HasTableName("Heroes")
            .HasSchemaName("public")
            .HasPrimaryKey(x => x.Id)
            .HasIdentity(x => x.Id);

        builder.Entity<Line>()  
            .HasTableName("Lines")
            .HasSchemaName("public")
            .HasPrimaryKey(x => x.Id)
            .HasIdentity(x => x.Id);

        builder.Entity<HeroToLine>()
            .HasTableName("HeroesToLines")
            .HasSchemaName("public")
            .HasPrimaryKey(x => x.Id)
            .HasIdentity(x => x.Id)
             .Association(x => x.Hero, x => x.HeroId, x => x.Id)
             .Association(x => x.Line, x => x.LineId, x => x.Id);

        builder.Build();
        return builder.MappingSchema;
    }

}
