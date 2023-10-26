using SFML.System;
using SFML.Window;

namespace Entities
{
    public class Brother : Entity
    {
        private readonly int HORIZONTAL_MOVEMENT = 1;
        private readonly int VERTICAL_MOVEMENT = 1;
        private readonly Keyboard.Key LEFT_BUTTON = Keyboard.Key.A;
        private readonly Keyboard.Key RIGHT_BUTTON = Keyboard.Key.D;
        private readonly Keyboard.Key UP_BUTTON = Keyboard.Key.W;
        private readonly Keyboard.Key DOWN_BUTTON = Keyboard.Key.S;

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

            if (e.Code == LEFT_BUTTON)
            {
                var position = Sprite.Position;
                Sprite.Position = new Vector2f(position.X - HORIZONTAL_MOVEMENT, position.Y);
            }

            if (e.Code == RIGHT_BUTTON)
            {
                var position = Sprite.Position;
                Sprite.Position = new Vector2f(position.X + HORIZONTAL_MOVEMENT, position.Y);
            }

            if (e.Code == UP_BUTTON)
            {
                var position = Sprite.Position;
                Sprite.Position = new Vector2f(position.X, position.Y - VERTICAL_MOVEMENT);
            }

            if (e.Code == DOWN_BUTTON)
            {
                var position = Sprite.Position;
                Sprite.Position = new Vector2f(position.X, position.Y  + VERTICAL_MOVEMENT);
            }
        }
    }
}
