namespace TextCommandPerformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Performer performer = new();
            performer.Perform(textBox1.Text);
        }
    }
}