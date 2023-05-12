using OpenCvSharp;
using Size = OpenCvSharp.Size;

namespace ResizeImage
{
    public partial class Form1 : Form
    {
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
                }
                else
                    txtLogo.Text = string.Empty;
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
            }
            else if (string.IsNullOrEmpty(txtLogo.Text))
            {
                MessageBox.Show("You must select logo image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtFrame.Text))
            {
                MessageBox.Show("You must choose frame file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtResultFolder.Text))
            {
                MessageBox.Show("You must choose result folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string[] imageFiles = Directory.GetFiles(txtImageFolder.Text, "*.jpg;*.png;*.jpeg");

            Mat frame = Cv2.ImRead(txtFrame.Text);
            Mat logo = Cv2.ImRead(txtLogo.Text);
            Size logoSize = new Size(Convert.ToInt32(frame.Width * nmrRatio.Value / 100), Convert.ToInt32(frame.Height * nmrRatio.Value / 100));
            Cv2.Resize(logo, logo, logoSize);
            int i = 0;
            foreach (string imageFile in imageFiles)
            {
                Mat frameClone = frame.Clone();
                Mat image = Cv2.ImRead(imageFile);
                if(image != null)
                {
                    image.CopyTo(frameClone[roi: new Rect(0, 0, frame.Width, frame.Height)]);
                    logo.CopyTo(frame[roi: new Rect(0, 0, logo.Width, logo.Height)]);
                    Cv2.ImWrite(txtResultFolder + "\\Result_" + i, frame);
                }
            }    
        }
    }
}