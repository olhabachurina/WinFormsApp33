namespace WinFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Forma1_Paint;
        }

        private void Forma1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font regularFont = new Font("Arial", 12, FontStyle.Regular);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.DrawString("Обычный текст", regularFont, blackBrush, 50, 50);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            g.DrawString("Жирный текст", boldFont, redBrush, 50, 80);
            Font italicFont = new Font("Arial", 12, FontStyle.Italic);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            g.DrawString("Курсив", italicFont, blueBrush, 50, 110);
            Font underlineFont = new Font("Arial", 12, FontStyle.Underline);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            g.DrawString("Подчеркнутый текст", underlineFont, greenBrush, 50, 140);
            g.Dispose();
        }
    }  
}