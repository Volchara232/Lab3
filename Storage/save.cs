using Models;
namespace Storage
{
    public interface IObject{
        public List<Ball> balls = new List<Ball>(); 
        public List<Brick> bricks = new List<Brick>(); 
        public List<Loot> loots = new List<Loot>(); 
        public Platform pl;
    }
    public class Control
    {
        string jsonString = JsonSerializer.Serialize(IObject);
    }
    public Save()
    {
            
    }

}