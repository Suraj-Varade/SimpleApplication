using Microsoft.EntityFrameworkCore;
using OnlineCodePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCodePlatform.DAL
{
    public class OnlineCodeContext : DbContext
    {
        public OnlineCodeContext(DbContextOptions<OnlineCodeContext> options) : base(options)
        {
        }
        public DbSet<ProblemStatement> ProblemStatements { get; set; }


    }
}
