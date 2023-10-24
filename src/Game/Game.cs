using Render;
using SFML.Graphics;

namespace Game
{
    public static class Window
    {
        public static void Run()
        {
            Renderer renderer = new();
            RenderWindow window = renderer.Window;

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                window.Display();
            }
        }
    }
}
