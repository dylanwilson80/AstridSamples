using Astrid.Windows;

namespace HelloWorld.Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new WindowsApplicationConfig
            {
                Title = "Hello Astrid",
                Width = 800,
                Height = 480,
            };

            using (var application = new WindowsApplication(config))
            {
                var game = new Game(application);
                application.Run(game);
            }
        }
    }
}
