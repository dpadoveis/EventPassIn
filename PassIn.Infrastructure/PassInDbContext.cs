using Microsoft.EntityFrameworkCore;
using PassIn.Infrastructure.Entities;


namespace PassIn.Infrastructure
{
    public class PassInDbContext : DbContext
    {
        //variavel p mapear e acessar a tabela de eventos no db
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        //metodo p configurar a database do sqlite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:\\Users\\Diogo\\source\\repos\\rocketseat\\PassIn\\PassInDb.db");
        }
    }
}
