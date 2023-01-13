using Tesseract;

namespace TextRecognition
{
    public partial class RecognizeForm : Form
    {
        public RecognizeForm()
        {
            InitializeComponent();
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new()
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {

                imagePB.Image = new Bitmap(open.FileName);

                imagePathTB.Text = open.FileName;
            }
        }

        private void RecognizeBtn_Click(object sender, EventArgs e)
        {
            var ocrengine = new TesseractEngine(@".\tessdata", "rus+eng", EngineMode.Default);
            var img = Pix.LoadFromFile(imagePathTB.Text);
            var res = ocrengine.Process(img);
            recognizedTextRTB.Text = res.GetText();
        }
    }
}
