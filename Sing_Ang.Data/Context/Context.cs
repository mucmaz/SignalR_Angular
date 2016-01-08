using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Sing_Ang.Entity;

namespace Sing_Ang.Data.Context
{
    public class Context : DbContext
    {
            
        public Context() : base("Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>("Context"));
        }           

        private static Context _context;  //  classın kendisinden propertiy oluşturulur.
        public static Context ContextOlustur()  //static metod oluşturuyoruz. metodu direk kullanılabilir yapmış oluyoruz.
        {
            if (_context == null)
            {
                _context = new Context();
            }

            return _context;
        }

        public DbSet<Product> Products { get; set; }
    }
}
