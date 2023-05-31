using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ImageService
{
    public class ImageServices
    {
        private Mat _image;
        public Mat Image { get => _image; set => _image = value; }

        private List<Point[]> _contours;
        public List<Point[]> Contours { get => _contours; set => _contours = value; }

        public ImageServices()
        {
        }
        public ImageServices(Mat image)
        {
            _image = image;
        }

        public void SaveImage(string filePath)
        {
            Cv2.ImWrite(filePath, _image);
        }

        public bool IsVertical(double ratio)
        {
            double div = (double)_image.Width / (double)_image.Height;

            if (div <= ratio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Mat CopyTo(Mat dst, Rect rect)
        {
            _image.CopyTo(dst[roi: rect]);
            return dst;
        }

        public Mat Resize(Mat dst, Size size)
        {
            Cv2.Resize(_image, dst, size);
            return dst;
        }
        public List<Point[]> FindContour()
        {
            _contours = GetAllContours(_image);
            return _contours;
        }

        private List<Point[]> GetAllContours(Mat image)
        {
            Mat refGray = new Mat();
            Cv2.CvtColor(image, refGray, ColorConversionCodes.BGR2GRAY);
            Mat canny = new Mat();

            Cv2.GaussianBlur(refGray, refGray, new Size(5,5), 0);

            Cv2.Canny(refGray, canny, 20, 50);

            Cv2.ImShow("Canny", canny);

            Point[][] contours;
            HierarchyIndex[] hIndx;
            Cv2.FindContours(canny, out contours, out hIndx, RetrievalModes.List, ContourApproximationModes.ApproxSimple);

            return contours.ToList();
        }

        public void DrawContours(int idx = -1)
        {
            if(_contours != null)
            {
                Cv2.DrawContours(_image, _contours, idx, Scalar.Black);
            }
        }
    }
}
