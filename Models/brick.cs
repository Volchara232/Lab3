using System.Drawing;

namespace Models
{
    public class Brick : Argument
    {
        public int Strength { get; set; }
        
        public int Width => 80;
        public int Height => 30;
        public override string Type => "Brick";
        
        
        
        public Brick(int x, int y, int strength, Color color)
        {
            X = x;
            Y = y;
            Strength = strength;
            Color = color;
        }
        
        public bool Hit()
        {
            Strength--;
            return Strength <= 0;
        }
        
    }
}