using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication10.Startup))]
namespace WebApplication10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            System.Console.WriteLine("Test1");
            System.Console.WriteLine("Test 2 youki");
            System.Console.WriteLine("Test 3 Marcin");

            System.Console.WriteLine("Test 4 Marcin");
            System.Console.WriteLine("Dziala !");

        }
    }
}
