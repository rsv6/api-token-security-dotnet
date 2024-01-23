using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiTokenSecurity.Models
{
    public class DbHubContext: DbContext
    {
        // O nome da propriedade do tipo DbSet precisa ser IGUAL ao 
        // nome da tabela no banco.
        public DbSet<Usuario> Usuario { get; set; }
        public DbHubContext(DbContextOptions<DbHubContext> options): base(options) {}
    }
}