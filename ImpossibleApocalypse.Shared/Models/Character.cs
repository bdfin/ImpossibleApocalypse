using System;

namespace ImpossibleApocalypse.Shared.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int HitPoints { get; set; } = 70;
        public int Strenght { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Luck { get; set; } = 5;
        public int Hunger { get; set; } = 5;

        public void ShowStats()
        {
            string stats = $@"
                +-----------STATS:-----------+
                |----------------------------|
                |--|  HP: { HitPoints }  || S: { Strenght }    |--|
                |--|  D : { Defence }  || I: { Intelligence }    |--| 
                |--|  L : { Luck }   || H: { Hunger }     |--| 
                |----------------------------|
                +----------------------------+";

            Console.WriteLine();
            Console.WriteLine(stats);
            Console.WriteLine();
        }
    }
}
