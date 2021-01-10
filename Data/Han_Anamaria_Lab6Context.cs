using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Han_Anamaria_Lab6.Models;

namespace Han_Anamaria_Lab6.Data
{
    public class Han_Anamaria_Lab6Context : DbContext
    {
        public Han_Anamaria_Lab6Context (DbContextOptions<Han_Anamaria_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Han_Anamaria_Lab6.Models.Book> Book { get; set; }
    }
}
