using RandomDraw.Data;
using RandomDraw.Models;

namespace RandomDraw.Repositories
{
    public interface IRaffleRepository
    {
        public bool Generate(Raffle raffle);
    }

    public class RaffleRepository : IRaffleRepository
    {
        private readonly RaffleContext _context;
        public RaffleRepository(RaffleContext context)
        {
            _context = context;
        }

        public bool Generate(Raffle raffle)
        {
            try
            {
                Draw(raffle);
                _context.Raffles.Add(raffle);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Draw(Raffle raffle)
        {
            Random random = new Random();
            int drawResult;
            raffle.Result = "";
            List<int> list = new List<int>();

            for (int i = 0; i < raffle.AmountOfNumbers; i++)
            {
                drawResult = random.Next(raffle.SmallestNumber, raffle.HigherNumber + 1);
                while (list.Contains(drawResult))
                {
                    drawResult = random.Next(raffle.SmallestNumber, raffle.HigherNumber + 1);
                }
                list.Add(drawResult);
                raffle.Result = raffle.Result + " " + drawResult;
            }
        }
    }
}
