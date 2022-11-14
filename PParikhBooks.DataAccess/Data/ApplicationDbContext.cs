using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PParikhBooks.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PParikhBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public static implicit operator ApplicationDbContext(ApplicationDbConetext v)
        {
            throw new NotImplementedException();
        }
    }
}
