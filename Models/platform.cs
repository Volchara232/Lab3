using System.Drawing;

namespace Models
{
   
    public class Platform : Argument
    {
        public int Size { get; set; }
        
        public override string Type => "Platform";
        
        public Platform(int x, int y, int size, Color color)
        {
            X = x;
            Y = y;
            Size = size;
            Color = color;
        }
        
        public void MoveLeft(int step = 5)
        {
            X -= step;
        }
        
        public void MoveRight(int step = 5)
        {
            X += step;
        }
    }
    
}