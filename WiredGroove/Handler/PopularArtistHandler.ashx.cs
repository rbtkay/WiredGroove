using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredGroove.Database;
using WiredGroove.Classes;
using System.Web.Script.Serialization;

namespace WiredGroove.Handler
{
    /// <summary>
    /// Summary description for PopularArtistHandler
    /// </summary>
    public class PopularArtistHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<PopularArtist> artistList = DataLayerFactory.Instance.GetPopularArtist();

            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(artistList));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}