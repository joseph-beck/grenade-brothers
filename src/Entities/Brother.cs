using SFML.System;
using SFML.Window;

namespace Entities
{
    public class Brother : Entity
    {
        private readonly int HORIZONTAL_MOVEMENT = 1;
        private readonly int VERTICAL_MOVEMENT = 1;
        public Brother(int x, int y)
        {
            Name = "Brother";
            Texture = new("assets/brother.png");
            Sprite = new(Texture)
            {
                Position = new Vector2f(x, y),
                Scale = new Vector2f(0.25f, 0.25f)
            };
        }

        public override void Update(KeyEventArgs e)
        {
            if (Sprite == null)
            {
                return;
            }

            if (e.Code == Keyboard.Key.A)
            {
                var position = Sprite.Position;
                Sprite.Position = new Vector2f(position.X - HORIZONTAL_MOVEMENT, position.Y);
            }

            if (e.Code == Keyboard.Key.D)
            {
                var position = Sprite.Position;
                Sprite.Position = new Vector2f(position.X + HORIZONTAL_MOVEMENT, position.Y);
            }
        }
    }
}