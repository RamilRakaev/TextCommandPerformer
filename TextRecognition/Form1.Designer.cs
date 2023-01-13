namespace TextRecognition
{
    partial class RecognizeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recognizePnl = new System.Windows.Forms.Panel();
            this.imagePB = new System.Windows.Forms.PictureBox();
            this.imagePathTB = new System.Windows.Forms.TextBox();
            this.recognizedTextRTB = new System.Windows.Forms.RichTextBox();
            this.recognizeTextLbl = new System.Windows.Forms.Label();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.recognizeBtn = new System.Windows.Forms.Button();
            this.recognizePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // recognizePnl
            // 
            this.recognizePnl.Controls.Add(this.imagePB);
            this.recognizePnl.Controls.Add(this.imagePathTB);
            this.recognizePnl.Controls.Add(this.recognizedTextRTB);
            this.recognizePnl.Controls.Add(this.recognizeTextLbl);
            this.recognizePnl.Location = new System.Drawing.Point(12, 12);
            this.recognizePnl.Name = "recognizePnl";
            this.recognizePnl.Size = new System.Drawing.Size(792, 364);
            this.recognizePnl.TabIndex = 0;
            // 
            // imagePB
            // 
            this.imagePB.Location = new System.Drawing.Point(3, 41);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(385, 279);
            this.imagePB.TabIndex = 3;
            this.imagePB.TabStop = false;
            // 
            // imagePathTB
            // 
            this.imagePathTB.Location = new System.Drawing.Point(3, 338);
            this.imagePathTB.Name = "imagePathTB";
            this.imagePathTB.Size = new System.Drawing.Size(384, 23);
            this.imagePathTB.TabIndex = 2;
            // 
            // recognizedTextRTB
            // 
            this.recognizedTextRTB.Location = new System.Drawing.Point(404, 41);
            this.recognizedTextRTB.Name = "recognizedTextRTB";
            this.recognizedTextRTB.Size = new System.Drawing.Size(385, 320);
            this.recognizedTextRTB.TabIndex = 1;
            this.recognizedTextRTB.Text = "";
            // 
            // recognizeTextLbl
            // 
            this.recognizeTextLbl.AutoSize = true;
            this.recognizeTextLbl.Location = new System.Drawing.Point(282, 9);
            this.recognizeTextLbl.Name = "recognizeTextLbl";
            this.recognizeTextLbl.Size = new System.Drawing.Size(221, 15);
            this.recognizeTextLbl.TabIndex = 0;
            this.recognizeTextLbl.Text = "Распознавание текста на изображении";
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(12, 392);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(156, 23);
            this.selectImageBtn.TabIndex = 1;
            this.selectImageBtn.Text = "Выбрать изображение";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // recognizeBtn
            // 
            this.recognizeBtn.Location = new System.Drawing.Point(174, 392);
            this.recognizeBtn.Name = "recognizeBtn";
            this.recognizeBtn.Size = new System.Drawing.Size(87, 23);
            this.recognizeBtn.TabIndex = 2;
            this.recognizeBtn.Text = "Распознать";
            this.recognizeBtn.UseVisualStyleBackColor = true;
            this.recognizeBtn.Click += new System.EventHandler(this.RecognizeBtn_Click);
            // 
            // RecognizeForm
            // 
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.recognizeBtn);
            this.Controls.Add(this.selectImageBtn);
            this.Controls.Add(this.recognizePnl);
            this.Name = "RecognizeForm";
            this.recognizePnl.ResumeLayout(false);
            this.recognizePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel recognizePnl;
        private Button selectImageBtn;
        private Label recognizeTextLbl;
        private Button recognizeBtn;
        private TextBox imagePathTB;
        private RichTextBox recognizedTextRTB;
        private PictureBox imagePB;
    }
}