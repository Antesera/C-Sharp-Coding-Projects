using System;
using System.Collections.Generic;
using System.Text;

namespace EFGettingStarted
{
    public class Context : DbContext
    {
        public object Student { get; internal set; }
        DbSet<Class> Classes { get; set; }

        DbSet<Student> Students { get; set; }
    }
}
