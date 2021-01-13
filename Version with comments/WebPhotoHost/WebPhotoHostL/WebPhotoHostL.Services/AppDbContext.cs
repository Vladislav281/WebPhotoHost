using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<AdminAccount> AdminAccount { get; set; }
    }
}
