using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pc4.Models;

namespace pc4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<pc4.Models.Fail> Fail { get; set; }

        public DbSet<pc4.Models.Comentario> Comentarios { get; set; }






    }
}
