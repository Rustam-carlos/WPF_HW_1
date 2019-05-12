using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HW_1
{
    class StudentContext : DbContext
    {
        public StudentContext()
            : base("DbConnection")
        { }

        public DbSet<Student> students { get; set; }
    }
}

