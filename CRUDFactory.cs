using CRUDph9.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class CRUDph9ContextFactory : IDesignTimeDbContextFactory<CRUDph9Context>
{
    public CRUDph9Context CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CRUDph9Context>();
        optionsBuilder.UseSqlite("Data Source=app.db"); // matches appsettings.json

        return new CRUDph9Context(optionsBuilder.Options);
    }
}
