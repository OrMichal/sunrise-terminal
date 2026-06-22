using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;
using Sunrise_Terminal.Core;
using Sunrise_Terminal.HelperPopUps;
using Sunrise_Terminal.Utilities;

namespace Sunrise_Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            Console.CursorVisible = false;
            Blockers.BlockCancelation();

            for (;;)
            {
                try
                {
                    app.Draw();
                    ConsoleKeyInfo info = Console.ReadKey(true);

                    app.HandleKey(info);

                }
                catch (System.IO.IOException)
                {
                    app.Api.ThrowError("Nein, this is being used");
                }
            }
        }
    }
}
