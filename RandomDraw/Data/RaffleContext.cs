using Microsoft.EntityFrameworkCore;

namespace RandomDraw.Data
{
    public class RaffleContext : DbContext
    {
        public RaffleContext(DbContextOptions<RaffleContext> options) : base(options)
        {
        }


    }



}
