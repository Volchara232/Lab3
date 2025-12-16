using System.Drawing;
using Interfaces;

namespace Models
{
    public class Ball : Argument
    {
        public int Radius { get; set; }
        public Speed Vector { get; set; }
        
        public override string Type => "Ball";
        
        public Ball(int x, int y, int radius, Speed vector, Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
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