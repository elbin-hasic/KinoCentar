using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoCentar.WinUI
{
    public class ConfigurationSettings
    {
        public static string API_ADDRESS
        {
            get
            {
                return ConfigurationManager.AppSettings["ApiAddress"];
            }
        }

        public static int RESIZED_IMAGE_WIDTH
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ConfigurationManager.AppSettings["ResizedImageWidth"]);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int RESIZED_IMAGE_HEIGHT
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ConfigurationManager.AppSettings["ResizedImageHeight"]);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int CROPPED_IMAGE_WIDTH
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ConfigurationManager.AppSettings["CroppedImageWidth"]);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int CROPPED_IMAGE_HEIGHT
        {
            get
            {
                try
                {
                    return Convert.ToInt32(ConfigurationManager.AppSettings["CroppedImageHeight"]);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
