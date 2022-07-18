using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Db
{
    class Contexts : DbContext
    {
        public Contexts(DbContextOptions<Contexts> options)
       : base(options)
        { }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}

        public DbSet<Student> Students { get; set; }
    }
}
