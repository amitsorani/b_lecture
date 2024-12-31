using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
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
                // Initialize the image on first load
                DisplayImage();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Change the image every 2 seconds
            currentIndex = (currentIndex + 1) % imageUrls.Count;
            DisplayImage();
        }

        private void DisplayImage()
        {
            // Set the image URL to the Image control
            Image1.ImageUrl = ResolveUrl("~/Images/" + imageUrls[currentIndex]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string filename = FileUpload1.FileName;
                    string folderPath = Server.MapPath("~/FILES/");

                    // Ensure the directory exists
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = Path.Combine(folderPath, filename);
                    FileUpload1.SaveAs(filePath);
                    Label1.Text = "File uploaded successfully.";
                }
                catch (Exception ex)
                {
                    Label1.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                Label1.Text = "Please select a file to upload.";
            }
        }
    }
}
