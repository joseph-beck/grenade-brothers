using Render;
using SFML.Graphics;

namespace Entities
{
    public class Entity
    {
        public Sprite Sprite { get; set; }
        public Texture Texture { get; set; }
        public string? Name { get; set; }

        public Entity()
        {

        }
    }
}