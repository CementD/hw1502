namespace Classwork1502
{
    public partial class Form1 : Form
    {
        /*private string[] imagePaths = new string[]
        {
            @"C:\Users\User\Pictures\information_items_property_3050.jpg",
            @"C:\Users\User\Pictures\8b8fbdc4aff151d2642c.jpeg",
            @"C:\Users\User\Pictures\images.jpeg"
        };*/
        private List<string> imagePaths = new List<string>
        {
            @"C:\Users\User\Pictures\information_items_property_3050.jpg",
            @"C:\Users\User\Pictures\8b8fbdc4aff151d2642c.jpeg",
        };

        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayImage();
        }

        private void DisplayImage()
        {
            if (imagePaths.Count > 0)
            {
                pictureBox1.Load(imagePaths[currentIndex]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = imagePaths.Count - 1;
            }
            DisplayImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex > imagePaths.Count - 1)
            {
                currentIndex = 0;
            }
            DisplayImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newImageURL = textBox1.Text;
            if (!string.IsNullOrEmpty(newImageURL) && (newImageURL.EndsWith(".jpg") || newImageURL.EndsWith(".jpeg") || newImageURL.EndsWith(".png")))
            {
                imagePaths.Add(newImageURL);
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Некоректний ввід! Введіть URl до зображення ще раз.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose File";
            openFileDialog1.Filter = "Зображення|*.png;*.jpeg;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                imagePaths.Add(filePath);
            }
        }
    }
}