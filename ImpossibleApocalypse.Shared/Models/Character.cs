namespace ImpossibleApocalypse.Shared.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int HitPoints { get; set; } = 100;
        public int Strenght { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Luck { get; set; } = 5;
        public int Hunger { get; set; } = 5;
    }
}
