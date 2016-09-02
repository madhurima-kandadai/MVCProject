using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleMVCTests.Startup))]
namespace ExampleMVCTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
			//test
        }
    }
}
