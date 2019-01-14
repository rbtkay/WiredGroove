﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using WiredGroove.Classes;
using WiredGroove.Database;

namespace WiredGroove
{
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (hiddenField.Value != null)
            {
                Session["generalSearch"] = Request.Form.Get("generalSearch");
            }
        }

        [WebMethod]
        public static List<PopularArtist> SearchResultArtist()
        {
            string name = string.Empty;
            string genre = string.Empty;
            string location = string.Empty;
            string instrument = string.Empty;

            //if (!String.IsNullOrEmpty(HttpContext.Current.Session["searchName"] as String))
            //{
                name = HttpContext.Current.Session["searchName"].ToString();
            //}
            //if (!String.IsNullOrEmpty(HttpContext.Current.Session["searchName"] as String))
            //{
                genre = HttpContext.Current.Session["searchGenre"].ToString();
            //}
            //if (!String.IsNullOrEmpty(HttpContext.Current.Session["searchName"] as String))
            //{
                location = HttpContext.Current.Session["searchLocation"].ToString();
            //}
            //if (!String.IsNullOrEmpty(HttpContext.Current.Session["searchName"] as String))
            //{
                instrument = HttpContext.Current.Session["searchInstrument"].ToString();
            //}

            //if(String.IsNullOrEmpty(name) && String.IsNullOrEmpty(genre) && String.IsNullOrEmpty(location) && String.IsNullOrEmpty(instrument))
            //{
                
            //}

            List<PopularArtist> artistList = DataLayerFactory.Instance.SearchResultArtist(name, genre, location, instrument);

            return artistList;
        }

        [WebMethod]
        public static List<PopularArtist> GeneralSearch()
        {
            string generalResult = HttpContext.Current.Session["generalResult"].ToString();

            List<PopularArtist> generalList = DataLayerFactory.Instance.GeneralSearch(generalResult);

            return generalList;
        }
    }
}