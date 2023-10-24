using System.Drawing;
using SFML.System;

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
    }
}