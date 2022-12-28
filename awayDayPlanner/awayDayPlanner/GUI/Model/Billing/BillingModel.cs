using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace awayDayPlanner.GUI.Model.Billing
{
    
    public class BillingModel : IBillingModel
    {
        public bool Confirmed;
        public string BuyerFirstName;
        public string BuyerLastName;
        public string BuyerFirstLineAddress;
        public string BuyerSecondLineAddress;
        public string BuyerPostCode;
        public string BuyerPhoneNumber;
        public string BuyerEmail;
        public double TotalCost;
        public AwayDay awayDay;

        public ICollection<Activity> AwayDayActivities;

        public BillingModel()
        {

        }

        public void Submit(AwayDay awayDay)
        {
            var frm = FormProvider.BillingForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"c:\temp\screenshot.png");
            }
        }

        public void SaveImageAsPdf(string imageFileName, string pdfFileName, int width = 600, bool deleteImage = false)
        {
            using (var document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                using (XImage img = XImage.FromFile(imageFileName))
                {
                    var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                    page.Width = width;
                    page.Height = height;

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(img, 0, 0, width, height);
                }
                document.Save(pdfFileName);
            }

            if (deleteImage)
                File.Delete(imageFileName);
        }




    }
}
