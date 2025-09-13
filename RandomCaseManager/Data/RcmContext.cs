using System;
using System.Data.Entity;
using System.Linq;
using RandomCaseManager.Data.Entities;

namespace RandomCaseManager.Data
{
    public class RcmContext : DbContext
    {
        // Your context has been configured to use a 'RcmContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RandomCaseManager.Data.RcmContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RcmContext' 
        // connection string in the application configuration file.
        public RcmContext()
            : base("name=RcmContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<DeployEnvironment> Environments { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}