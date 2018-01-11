using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLogger.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TLDbContext : DbContext
    {
        public TLDbContext() { }

        public TLDbContext(String nameOrConnectionString) 
            : base(nameOrConnectionString)
        { }

        public TLDbContext(DbConnection existingConnection,Boolean contextOwnsConnection) 
            : base(existingConnection, contextOwnsConnection)
        { }


        public DbSet<Project> Projects { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }


}
