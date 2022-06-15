using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Engine.Property;

namespace SimpleCompanyWebsite.Code
{
    public class ContentQueryHelper
    {

        public static List<string> GetImagesFromFileFolder(InnerContentsPropertyValue<InnerFile> images, int width = 0, int height = 0, int quality = 85)
        {
            var adjust = new ImageAdjustments();
            if (width != 0)
                adjust.CanvasX = width;
            if (height != 0)
                adjust.CanvasY = height;

            adjust.Quality = quality;


            List<string> s = new List<string>();
            foreach (var file in images.GetAll())
            {
                if (file.File.IsImage())
                {
                    s.Add(file.File.GetUrl(adjust));
                }
            }


            return s;

        }
    }
}