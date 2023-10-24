using SFML.Graphics;
using SFML.Window;

namespace Entities
{
    public class Entity
    {
        public Sprite? Sprite { get; set; }
        public Texture? Texture { get; set; }
        public string? Name { get; set; }

        public Entity() { }

        public virtual void Update(KeyEventArgs e) { }
    }
}