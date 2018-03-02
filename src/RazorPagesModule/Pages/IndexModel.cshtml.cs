using DotNetNuke.Web.Mvc.RazorPages.SDK;

namespace DNNTAG.RazorPagesModule.Pages
{
    public class IndexModel : DnnPageModel
    {        
        
        public IndexModel()
        {            
        }

        // TODO - Add on Get and on post handlers, see - https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/?tabs=visual-studio

        public string WelcomeMessage => "Hello DNN Razor Pages, it's a brand new world!";
    }
}