using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Context
{
    public class WebAppContext :DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {

        }

     
        public DbSet<Book> Books { get; set; }
    }
}
