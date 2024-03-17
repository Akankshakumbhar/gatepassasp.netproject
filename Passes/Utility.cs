using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // Add this line

namespace Passes
{
    internal class Utility
    {
        public static void  onlyNumber(KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char .IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        public static string GetUniqueId(string prefix)
        {
            long nano = Stopwatch.GetTimestamp();
            nano *= 100L; // Convert ticks to nanoseconds

            string uniqueId = $"{prefix}_{nano}";

            return uniqueId;
        }
        public static String getImageStorePath(String imageName)
        {
            return Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Images\\" + imageName + ".jpg";
        }
        public static void setImageInPictureBox(PictureBox pictureBoxProfile,String visitorId)
        {
            String path = getImageStorePath(visitorId);
            if (pictureBoxProfile.Image != null)
            {
                pictureBoxProfile.Image.Dispose();
                pictureBoxProfile.Image = null;

            }
            pictureBoxProfile.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.Image=Image.FromFile(path);
        }
    }
}
