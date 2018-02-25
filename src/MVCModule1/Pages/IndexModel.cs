using DotNetNuke.Common;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.UI.Modules;
using DotNetNuke.Web.Mvc.RazorPages;
using DotNetNuke.Web.Mvc.RazorPages.Framework.ActionResults;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DNNSummit.MVCModule1.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {            
        }

        // TODO - Add on Get and on post handlers, see - https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/?tabs=visual-studio

        public string WelcomeMessage => "Hello DNN Razor Pages, it's a brand new world!";
    }
}