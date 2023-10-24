using SFML.System;
using SFML.Window;

namespace Entities
{
    public class Grenade : Entity
    {
        public Boolean HasExploded { get; private set; }

        public Grenade()
        {
            Name = "Grenade";
            Texture = new("assets/grenade.png");
            Sprite = new(Texture)
            {
                Position = new Vector2f(50, 50),
                Scale = new Vector2f(0.25f, 0.25f)
            };
        }

        public void Explode()
        {
            HasExploded = true;
        }

        public override void Update(KeyEventArgs? e)
        {
            if (e != null)
            {
                return;
            }

            if (Sprite == null)
            {
                return;
            }

            var position = Sprite.Position;
            Sprite.Position = new Vector2f(position.X, position.Y + 1);
        }
    }
}