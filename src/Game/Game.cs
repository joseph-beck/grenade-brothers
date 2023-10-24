using Render;
using Entities;
using SFML.Graphics;
using SFML.Window;

namespace Game
{
    public static class Window
    {
        private static Grenade _grenade = new();
        private static Brother _leftBrother = new(50, 400);
        private static Brother _rightBrother = new(500, 400);

        public static void Run()
        {
            Renderer renderer = new();
            RenderWindow window = renderer.Window;

            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.KeyPressed += Exit;
                window.KeyPressed += Update;

                _grenade.Update(null);

                window.Clear(Color.Black);

                window.Draw(_grenade.Sprite);
                window.Draw(_leftBrother.Sprite);
                window.Draw(_rightBrother.Sprite);

                window.Display();
            }
        }

        private static void Update(object? sender, KeyEventArgs? e)
        {
            if (e == null)
            {
                return;
            }

            _leftBrother.Update(e);
        }

        private static void Exit(object? sender, KeyEventArgs? e)
        {
            if (e == null)
            {
                return;
            }

            if (e.Code == Keyboard.Key.Escape)
            {
                Environment.Exit(1);
            }
        }
    }
}