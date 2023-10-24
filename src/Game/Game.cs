using Render;
using Entities;
using SFML.Graphics;

namespace Game
{
    public static class Window
    {
        public static void Run()
        {
            Renderer renderer = new();
            RenderWindow window = renderer.Window;

            Grenade grenade = new();

            while (window.IsOpen)
            {
                window.Clear(Color.Black);
                window.Draw(grenade.Sprite);
                window.Display();
                window.DispatchEvents();
            }
        }
    }
}
