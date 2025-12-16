using System.Drawing;
using Interfaces;
namespace Models
{
    public abstract class Argument : IGameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public abstract string Type { get; }
        
        protected Argument()
        {
        }
    }
}