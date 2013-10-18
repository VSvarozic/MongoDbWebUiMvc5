using MDB.Domain.Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDB.Data.EF
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("DefaultConnection") { }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
