namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7223/Category/GetAllCategory");
            var response = client.Send(request);
            response.EnsureSuccessStatusCode();
            //Console.WriteLine(response.Content.ReadAsStringAsync());
            dataGridView1.DataSource = response.Content;

        }

        /// <summary>
        /// ekle butonu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://localhost:7223/Category/AddCategory?categoryName={textBox1.Text}");
            var response = client.Send(request);
            response.EnsureSuccessStatusCode();
            response.Content.ReadAsStringAsync();

        }

        /// <summary>
        /// sil butonu
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}