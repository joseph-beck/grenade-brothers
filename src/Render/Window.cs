using SFML.Graphics;
using SFML.Window;

namespace Render
{
    public class Renderer
    {
        private const int WIDTH = 640;
        private const int HEIGHT = 480;
        private const string TITLE = "Grenade Brothers";

        public RenderWindow Window { get; private set; }

        public Renderer()
        {
            VideoMode mode = new(WIDTH, HEIGHT);
            Window = new RenderWindow(mode, TITLE);

            Window.SetVerticalSyncEnabled(true);

            Window.Closed += (sender, args) => Window.Close();
        }
    }
}