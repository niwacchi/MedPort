using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PdfTest.Startup))]
namespace PdfTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
