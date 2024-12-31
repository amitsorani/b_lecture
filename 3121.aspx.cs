using System;
using System.Collections.Generic;
using System.Web.UI;

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
            Image1.ImageUrl = imageUrls[currentIndex];
        }
    }
}
