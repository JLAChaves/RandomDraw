using Microsoft.EntityFrameworkCore;
using RandomDraw.Models;

namespace RandomDraw.Data
{
    public class RaffleContext : DbContext
    {
        public RaffleContext(DbContextOptions<RaffleContext> options) : base(options)
        {
        }

        public DbSet<Raffle> Raffles { get; set; }


    }



}
