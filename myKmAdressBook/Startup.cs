using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myKmAdressBook.Startup))]
namespace myKmAdressBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
   
        }
    }
}
