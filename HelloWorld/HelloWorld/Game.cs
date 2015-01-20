using Astrid.Core;
using Astrid.Framework;

namespace HelloWorld
{
    public class Game : GameBase
    {
        public Game(ApplicationBase application)
            : base(application)
        {
        }

        public override void Create()
        {
        }

        public override void Destroy()
        {
        }

        public override void Pause()
        {
        }

        public override void Resume()
        {
        }

        public override void Resize(int width, int height)
        {
        }

        public override void Update(float deltaTime)
        {
        }

        public override void Render(float deltaTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);
        }
    }
}
