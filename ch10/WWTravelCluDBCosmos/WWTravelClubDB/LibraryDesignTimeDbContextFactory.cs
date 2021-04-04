using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WWTravelClubDB
{
    public class LibraryDesignTimeDbContextFactory
        : IDesignTimeDbContextFactory<MainDbContext>
    {
        private const string endpoint = "<your account endpoint>";
        private const string key = "<your account keys>";
        private const string databaseName = "packagesdb";

        public MainDbContext CreateDbContext(params string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainDbContext>();
            builder.UseCosmos(endpoint, key, databaseName);
            return new MainDbContext(builder.Options);
        }
    }

}
