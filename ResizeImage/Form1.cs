using ImageService;
using OpenCvSharp;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Point = OpenCvSharp.Point;
using Size = OpenCvSharp.Size;

namespace ResizeImage
{
    public partial class Form1 : Form
    {
        private ImageServices _logoPictureBoxService;
        private bool floodFill = true;
        private bool isMousePress = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseImageFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = dialog.SelectedPath;
                    txtImageFolder.Text = selectedFolder;
                }
                else
                {
                    txtImageFolder.Text = string.Empty;
                }
            }
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select an image file";
                dialog.Filter = "Image Files (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFile = dialog.FileName;
                    txtLogo.Text = selectedFile;
                    ImageServices logoService = new ImageServices(Cv2.ImRead(txtLogo.Text).Clone());

                    Mat logoResize = new Mat();
                    logoService.Resize(logoResize, new Size(picLogo.Width, picLogo.Height));
                    _logoPictureBoxService = new ImageServices(logoResize);
                    _logoPictureBoxService.ListImage.Empty();
                    _logoPictureBoxService.ListImage.Add(logoResize.Clone());
                    picLogo.Image = ConvertMatToBitmap(logoResize);
                }
                else
                {
                    txtLogo.Text = string.Empty;
                    picLogo.Image = null;
                    _logoPictureBoxService = null;
                }
            }
        }

        public Bitmap ConvertMatToBitmap(Mat mat)
        {
            byte[] byteArray;
            Cv2.ImEncode(".bmp", mat, out byteArray);

            // Create Bitmap from byte array
            using (var stream = new MemoryStream(byteArray))
            {
                return new Bitmap(stream);
            }
        }

        private void btnFrame_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select an image file";
                dialog.Filter = "Image Files (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFile = dialog.FileName;
                    txtFrame.Text = selectedFile;
                }
                else
                    txtFrame.Text = string.Empty;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = dialog.SelectedPath;
                    txtResultFolder.Text = selectedFolder;
                }
                else
                {
                    txtResultFolder.Text = string.Empty;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImageFolder.Text))
            {
                MessageBox.Show("You must select image folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtLogo.Text))
            {
                MessageBox.Show("You must select logo image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtFrame.Text))
            {
                MessageBox.Show("You must choose frame file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtResultFolder.Text))
            {
                MessageBox.Show("You must choose result folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] imageFiles = Directory.GetFiles(txtImageFolder.Text);

            Mat frameImage = Cv2.ImRead(txtFrame.Text);
            Mat logo = Cv2.ImRead(txtLogo.Text);

            ImageServices imageService;
            ImageServices logoCloneService;
            ImageServices frameCloneService;

            int frameWidth = frameImage.Width;
            int frameHeight = frameImage.Height;
            double frameRate = 1;
            
            var imgArray = new Mat[imageFiles.Length];

            int k = 0;
            foreach (string imageFile in imageFiles)
            {
                string extension = Path.GetExtension(imageFile).ToLower();
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {
                    Mat image = Cv2.ImRead(imageFile);

                    imgArray[k] = image;

                    //imageService = new ImageServices(image);

                    //Mat logoClone = logo.Clone();
                    //logoCloneService = new ImageServices(logoClone);

                    //Size logoSize = new Size(Convert.ToInt32(logoClone.Width * nmrRatio.Value / 100), Convert.ToInt32(logoClone.Height * nmrRatio.Value / 100));

                    //logoCloneService.Resize(logoCloneService.Image, logoSize);


                    //Mat frameClone = frameImage.Clone();
                    //frameCloneService = new ImageServices(frameClone);

                    //if (imageService.Image != null)
                    //{
                    //    if (imageService.Image.Width > frameCloneService.Image.Width || !imageService.IsVertical((double)nmrWDivH.Value))
                    //    {
                    //        imageService.Resize(imageService.Image, new Size(frameCloneService.Image.Width, imageService.Image.Height));
                    //    }
                    //    if (image.Height > frameImage.Height || imageService.IsVertical((double)nmrWDivH.Value))
                    //    {
                    //        imageService.Resize(imageService.Image, new Size(imageService.Image.Width, frameCloneService.Image.Height));
                    //    }

                    //    //image.CopyTo(frameClone[roi: new Rect(frame.Width / 2 - image.Width / 2, frame.Height / 2 - image.Height / 2, image.Width, image.Height)]);
                    //    imageService.CopyTo(frameCloneService.Image, new Rect(frameImage.Width / 2 - image.Width / 2, frameImage.Height / 2 - image.Height / 2, image.Width, image.Height));

                    //    int i = frameCloneService.Image.Width / 2 - imageService.Image.Width / 2;
                    //    int j = (frameCloneService.Image.Height) - (frameCloneService.Image.Height / 2 - imageService.Image.Height / 2) - logoCloneService.Image.Height;

                    //    int logoX = i + (int)nmrX.Value;
                    //    int logoY = j - (int)nmrY.Value;

                    //    Point image_topleft = new Point(frameImage.Width / 2 - image.Width / 2, frameImage.Height / 2 - image.Height / 2);
                    //    Point image_topright = new Point(frameImage.Width / 2 - image.Width / 2 + image.Width, frameImage.Height / 2 - image.Height / 2);
                    //    Point image_bottomleft = new Point(frameImage.Width / 2 - image.Width / 2, frameImage.Height / 2 - image.Height / 2 + image.Height);
                    //    Point image_bottomright = new Point(frameImage.Width / 2 - image.Width / 2 + image.Width, frameImage.Height / 2 - image.Height / 2 + image.Height);

                    //    if (logoX > image_topright.X - logoCloneService.Image.Width)
                    //    {
                    //        logoX = image_topright.X - logoCloneService.Image.Width;
                    //    }
                    //    if (logoY < image_topleft.Y)
                    //    {
                    //        logoY = image_topleft.Y;
                    //    }


                    //    Rect roi = new Rect(logoX, logoY, logoCloneService.Image.Width, logoCloneService.Image.Height);
                    //    Mat croppedImage;
                    //    try
                    //    {
                    //        croppedImage = new Mat(frameCloneService.Image, roi);
                    //    }
                    //    catch
                    //    {
                    //        continue;
                    //    }
                    //    for (int y = 0; y < logoClone.Height; y++)
                    //    {
                    //        for (int x = 0; x < logoClone.Width; x++)
                    //        {
                    //            Point logoPicPoint = (Point)GetEquipvalentPoint(logoClone, _logoPictureBoxService.Image, new Point(x, y));

                    //            var pixel = _logoPictureBoxService.Image.At<Vec3b>(logoPicPoint.Y, logoPicPoint.X);

                    //            // Access the individual color channels (BGR)
                    //            byte blue = pixel.Item0;
                    //            byte green = pixel.Item1;
                    //            byte red = pixel.Item2;
                    //            if (blue == 0 && green == 0 && red == 0)
                    //            {
                    //                var pixelCropImage = croppedImage.At<Vec3b>(y, x);
                    //                logoCloneService.Image.Set(y, x, new Vec3b(pixelCropImage.Item0, pixelCropImage.Item1, pixelCropImage.Item2));
                    //            }
                    //        }
                    //    }

                    //    logoCloneService.CopyTo(frameCloneService.Image, new Rect(logoX, logoY, logoClone.Width, logoClone.Height));

                    //    // Create the full file path
                    //    string filePath = Path.Combine(txtResultFolder.Text, "Result_" + k + ".jpg");

                    //    frameCloneService.SaveImage(filePath);
                    //}
                    k++;  
                }
            }

            Size size = new Size(frameImage.Width, frameImage.Height);
            VideoWriter videoWriter = new VideoWriter(Path.Combine(txtResultFolder.Text, "Video" + ".avi"),
                FourCC.XVID, 60, size);
            foreach (Mat img in imgArray)
            {
                videoWriter.Write(img);
            }


            videoWriter.Release();
            Process.Start("explorer.exe", txtResultFolder.Text);
        }
        private Point? GetEquipvalentPoint(Mat src, Mat dst, Point srcPoint)
        {
            if (IsPointInImage(src, srcPoint))
            {
                double scaleX = (double)src.Width / dst.Width;
                double scaleY = (double)src.Height / dst.Height;

                Point resizedPoint = new Point((int)(srcPoint.X / scaleX), (int)(srcPoint.Y / scaleY));
                return resizedPoint;
            }
            return null;
        }

        private bool IsPointInImage(Mat image, Point point)
        {
            if (point.X >= 0 && point.X < image.Width && point.Y >= 0 && point.Y < image.Height)
            {
                return true;
            }
            return false;
        }

        private void nmrWDivH_ValueChanged(object sender, EventArgs e)
        {
            // Retrieve the entered value
            decimal enteredValue;

            // Try to parse the text value
            if (decimal.TryParse(nmrWDivH.Value.ToString(), out enteredValue))
            {
                // Check if the value is outside the range
                if (enteredValue < 0 || enteredValue > 1)
                {
                    // Show an error message
                    MessageBox.Show("Value must be between 0 and 1.");
                    nmrWDivH.Value = (decimal)1;
                }
            }
            else
            {
                // Show an error message for invalid input
                MessageBox.Show("Invalid input. Please enter a valid decimal value.");
            }
        }

        private void picLogo_MouseClick(object sender, MouseEventArgs e)
        {
            if (_logoPictureBoxService != null)
            {
                Point position = new Point(e.X, e.Y);
                int currentIndex = _logoPictureBoxService.ListImage.CurrentIndex;
                int listImageCount = _logoPictureBoxService.ListImage.Count;

                for (int i = currentIndex + 1; i <= listImageCount - 1; i++)
                {
                    _logoPictureBoxService.ListImage.Remove(i);
                    listImageCount--;
                }
                Mat imageClone = _logoPictureBoxService.Image.Clone();

                if (floodFill)
                {
                    Cv2.FloodFill(imageClone, position, Scalar.Black);
                }
                else
                {
                    imageClone.Set(e.Location.Y, e.Location.X, new Vec3b(0, 0, 0));
                }

                _logoPictureBoxService.ListImage.Add(imageClone);
                if (_logoPictureBoxService.ListImage.CurrentIndex < _logoPictureBoxService.ListImage.MaxSize - 1)
                {
                    _logoPictureBoxService.ListImage.CurrentIndex++;
                }

                _logoPictureBoxService.Image = imageClone;

                picLogo.Image = ConvertMatToBitmap(_logoPictureBoxService.Image);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_logoPictureBoxService != null)
            {
                _logoPictureBoxService.Image = _logoPictureBoxService.OriginalImage.Clone();
                _logoPictureBoxService.ListImage.Empty();
                _logoPictureBoxService.ListImage.Add(_logoPictureBoxService.Image.Clone());
                picLogo.Image = ConvertMatToBitmap(_logoPictureBoxService.Image);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_logoPictureBoxService != null)
            {
                if (_logoPictureBoxService.ListImage.Count > 0)
                {
                    if (_logoPictureBoxService.ListImage.CurrentIndex >= 0)
                    {
                        if (_logoPictureBoxService.ListImage.CurrentIndex != 0)
                        {
                            _logoPictureBoxService.ListImage.CurrentIndex--;
                            _logoPictureBoxService.Image = _logoPictureBoxService.ListImage.Get(_logoPictureBoxService.ListImage.CurrentIndex);
                            picLogo.Image = ConvertMatToBitmap(_logoPictureBoxService.Image);
                        }
                    }
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (_logoPictureBoxService != null)
            {
                if (_logoPictureBoxService.ListImage.Count > 0)
                {
                    if (_logoPictureBoxService.ListImage.CurrentIndex < (_logoPictureBoxService.ListImage.Count - 1))
                    {
                        _logoPictureBoxService.ListImage.CurrentIndex++;
                        _logoPictureBoxService.Image = _logoPictureBoxService.ListImage.Get(_logoPictureBoxService.ListImage.CurrentIndex);
                        picLogo.Image = ConvertMatToBitmap(_logoPictureBoxService.Image);
                    }
                    else if (_logoPictureBoxService.ListImage.CurrentIndex == (_logoPictureBoxService.ListImage.Count - 1))
                    {
                        _logoPictureBoxService.Image = _logoPictureBoxService.ListImage.Get(_logoPictureBoxService.ListImage.CurrentIndex);
                        picLogo.Image = ConvertMatToBitmap(_logoPictureBoxService.Image);
                    }
                }
            }
        }
        private void rdoFill_CheckedChanged(object sender, EventArgs e)
        {
            floodFill = true;
        }

        private void rdoDraw_CheckedChanged(object sender, EventArgs e)
        {
            floodFill = false;
        }

        private void picLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress && !floodFill)
            {
                _logoPictureBoxService.Image.Set(e.Location.Y, e.Location.X, new Vec3b(0, 0, 0));
                picLogo.Image = ConvertMatToBitmap(_logoPictureBoxService.Image);
            }
        }

        private void picLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMousePress = true;
            }
        }

        private void picLogo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !floodFill)
            {
                isMousePress = false;
                _logoPictureBoxService.ListImage.Add(_logoPictureBoxService.Image);
                if (_logoPictureBoxService.ListImage.CurrentIndex < _logoPictureBoxService.ListImage.MaxSize - 1)
                {
                    _logoPictureBoxService.ListImage.CurrentIndex++;
                }
            }
        }

        private void picLogo_MouseLeave(object sender, EventArgs e)
        {
            if (!floodFill)
            {
                isMousePress = false;
            }
        }
    }
}