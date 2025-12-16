using System.Drawing;
using Interfaces;

namespace Models
{
    public class Loot : Argument
    {
        public Speed Vector { get; set; }
        public LootType TypeEnum { get; set; }
        
        public override string Type => "Loot";
        
        public enum LootType
        {
            ExpandPlatform,
            ShrinkPlatform,
            ExtraBall,
            SlowBall,
            FastBall
        }
        
        public Loot(int x, int y, LootType type, Speed vector, Color color)
        {
            X = x;
            Y = y;
            TypeEnum = type;
            Vector = vector;
            Color = color;
        }
        
        public void Move()
        {
            X += (int)Vector.x;
            Y += (int)Vector.y;
        }
}
}