using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutsMultiplos.Helpers
{
    public class Tema
    {
        public static string TemaAtual()
        {
            var url = HttpContext.Current.Request.Url.Host;
            url = url.Replace("www", "");
            return url;        
        }
    }
}