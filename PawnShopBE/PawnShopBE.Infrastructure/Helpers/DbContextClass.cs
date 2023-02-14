using Microsoft.EntityFrameworkCore;
using PawnShopBE.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Infrastructure.Helpers
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        #region DbSet
        public DbSet<User>? User { get; set; }
        #endregion
    }
}
