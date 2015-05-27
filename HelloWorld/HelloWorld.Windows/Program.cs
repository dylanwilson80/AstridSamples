using Astrid.Windows;

namespace HelloWorld.Windows
{
    class Program
    {
        static void Main()
        {
            var config = new WindowsApplicationConfig
            {
                WindowTitle = "Hello Astrid",
                WindowWidth = 800,
                WindowHeight = 480,
                ContentPath = "Content"
            };

            using (var application = new WindowsApplication(config))
            {
                var game = new Game(application);
                application.Run(game);
            }
        }
    }
}
