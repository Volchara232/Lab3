using System.Collections.Generic;

namespace Models
{
    public class GameState
    {
        public List<Ball> Balls { get; set; } = new List<Ball>();
        public List<Brick> Bricks { get; set; } = new List<Brick>();
        public List<Loot> Loots { get; set; } = new List<Loot>();
        public Platform? Platform { get; set; }
        public int Score { get; set; }
        public int Lives { get; set; }
        public int Level { get; set; }
    }
}