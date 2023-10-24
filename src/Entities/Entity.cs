using Render;

namespace Entities
{
    public class Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Name { get; set; }
        public Texture? Texture { get; set; }

        public Entity()
        {

        }
    }
}