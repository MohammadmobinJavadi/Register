using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace sabt_name
{
    class db : DbContext
    {
        public db():base("sabt name")
        {

        }
        public DbSet<Human> Humans { set; get; }
        
      
    }
}
