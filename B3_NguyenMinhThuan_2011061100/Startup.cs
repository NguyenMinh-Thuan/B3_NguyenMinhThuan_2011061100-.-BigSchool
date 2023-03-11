using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B3_NguyenMinhThuan_2011061100.Startup))]
namespace B3_NguyenMinhThuan_2011061100
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
