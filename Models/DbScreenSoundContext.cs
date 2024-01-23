using Microsoft.EntityFrameworkCore;

namespace ApiTokenSecurity.Models;

public class DbScreenSoundContext: DbContext
{
    public DbSet<Artista> Artistas { get; set; }
    public DbScreenSoundContext(DbContextOptions<DbScreenSoundContext> options) : base(options) {}
}