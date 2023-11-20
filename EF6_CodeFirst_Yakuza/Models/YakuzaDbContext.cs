using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6_CodeFirst_Yakuza.Models
{
    public class YakuzaDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Principal_Clan> PrincipalClans { get; set; }
        public DbSet<Yakuza> Yakuzas { get; set; }
        public DbSet<Yakuza_Hierarchy> YakuzaHierarchies { get; set; }

        public YakuzaDbContext() : base("Task3YakuzaDbConnection")
        {
            Database.SetInitializer(new YakuzaDbInitializer());
        }
    }
}