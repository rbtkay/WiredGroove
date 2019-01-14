using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using WiredGroove.Database;
using WiredGroove.Classes;
using System.Web.Services;
using System.IO;

namespace WiredGroove
{
    public partial class sHomePage : System.Web.UI.Page
    {
        public static string emailLogIn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Session["signInEmail"] as string))
            {
                Response.Redirect("SignIn.aspx");
            }
            else
            {
                if (!(String.IsNullOrEmpty(Session["musician"] as string)))
                    hiddenField.Value = Session["musician"].ToString();
            }


        }

        [WebMethod]
        public static List<PopularArtist> GetArtists()
        {
            List<PopularArtist> artistList = DataLayerFactory.Instance.GetPopularArtist();
            return artistList;
            //string artistList = "Cats";
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //js.Serialize(artistList);
            //var employers = _employerRepository.GetByTaxId(taxId).ToList();
            //var agencies = _employerRepository.GetByTaxId(taxId).Select(e => e.GeneralAgency).ToArray();
            //return Json(new { success = true, employers, agencies }, JsonRequestBehavior.AllowGet);
        }

        [WebMethod]
        public static List<Event> GetListJobs()
        {
            List<Event> artistList = DataLayerFactory.Instance.GetJobOffers();
            return artistList;
        }

        [WebMethod]
        public static List<Media> GetNewsFeed()
        {
            List<Media> newFeed = DataLayerFactory.Instance.GetAllMedia();
            return newFeed;
        }


        protected void btnUpload_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedfile = FileUpload.PostedFile;

            string fileName = Path.GetFileName(postedfile.FileName);
            string fileExtension = Path.GetExtension(fileName);

            string fileType = string.Empty;
            if (fileExtension == ".jpg" || fileExtension == "gif" || fileExtension == "bmp" || fileExtension == "png")
            {
                fileType = "Image";
            }
            else if(fileType == ".mp3" || fileType == ".m4a" || fileType == ".flac" || fileType == ".aac")
            {
                fileType = "Audio";
            }
            else
            {
                return;
            }

            int fileSize = postedfile.ContentLength;

            postedfile.SaveAs(Server.MapPath("~/Images/") + fileName);

            string filePath = "~/Images/" + fileName;

            //Stream stream = postedfile.InputStream;
            //BinaryReader binaryReader = new BinaryReader(stream);
            //byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

            DataLayerFactory.Instance.UploadMedia(Session["signInEmail"].ToString(), fileName, filePath, fileType);

            //byte[] buffer;

            //if (FileUpload.HasFile && FileUpload.PostedFile != null && FileUpload.PostedFile.FileName != "")
            //{

            //    HttpPostedFile file = FileUpload.PostedFile;

            //    buffer = new byte[file.ContentLength];
            //    int bytesReaded = file.InputStream.Read(buffer, 0, FileUpload.PostedFile.ContentLength);

            //    if (bytesReaded > 0)
            //    {
            //        string path = "~/Images/" + FileUpload.FileName;
            //        FileUpload.SaveAs(Server.MapPath(path));
            //        DataLayerFactory.Instance.UploadMedia(Session["signInEmail"].ToString(), FileUpload.FileName, path, buffer);
            //    }
            //}
        }
    }
}