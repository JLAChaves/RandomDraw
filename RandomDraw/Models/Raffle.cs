namespace RandomDraw.Models
{
    public class Raffle
    {
        public int Id { get; set; }
        public int SmallestNumber { get; set; }
        public int HigherNumber { get; set; }
        public int AmountOfNumbers { get; set; }
        public string? Result { get; set; }
    }
}
