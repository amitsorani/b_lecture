using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo1
{
    public partial class _3121 : System.Web.UI.Page
    {
        private static List<string> imageUrls = new List<string>
        {
            "1.jpeg",
            "2.jpeg",
            "3.png"
        };

        private static int currentIndex = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayImage();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imageUrls.Count;
            DisplayImage();
        }

        private void DisplayImage()
        {
            string imagePath = Server.MapPath("~/IMG/1.jpeg" + imageUrls[currentIndex]);

            if (File.Exists(imagePath))
            {
                Image1.ImageUrl = ResolveUrl("~/IMG/2.jpeg" + imageUrls[currentIndex]);
            }
            else
            {
                Image1.ImageUrl = ResolveUrl("~/IMG/3.png"); // Fallback image
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //    if (FileUpload1.HasFile)
            //    {
            //        try
            //        {
            //            string filename = Path.GetFileName(FileUpload1.FileName);
            //            string filePath = Server.MapPath("~/IMG/1.jpeg") + filename;

            //            // Ensure the directory exists
            //            if (!Directory.Exists(Server.MapPath("~/IMG/2.jpeg")))
            //            {
            //                Directory.CreateDirectory(Server.MapPath("~/IMG/3.png"));
            //            }

            //            // Save the uploaded file in the IMG folder
            //            FileUpload1.SaveAs(filePath);

            //            // Add the file name to the imageUrls list if it's an image
            //            if (filename.EndsWith("1.jpeg", StringComparison.OrdinalIgnoreCase) ||
            //                filename.EndsWith("2.jpeg", StringComparison.OrdinalIgnoreCase) ||
            //                filename.EndsWith("3.png", StringComparison.OrdinalIgnoreCase))
            //            {
            //                imageUrls.Add(filename);
            //                Label1.Text = "File uploaded successfully and added to slideshow!";
            //            }
            //            else
            //            {
            //                Label1.Text = "File uploaded successfully, but it's not an image.";
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Label1.Text = "Error: " + ex.Message;
            //        }
            //    }
            //    else
            //    {
            //        Label1.Text = "Please select a file to upload.";
            //    }
        }
    }
}
