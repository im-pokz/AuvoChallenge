using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuvoChallenge.Models
{
    public class AuvoChallengeContext : DbContext
    {
        public AuvoChallengeContext (DbContextOptions<AuvoChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<AuvoChallenge.Models.Transfer> Transfer { get; set; }
    }
}
