namespace Baist_kayıt_arayüzü

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.İsimsoyisminiz.Text = İsimsoyisim.Text;
            form2.Telefonno.Text = telno.Text;
            form2.Yasadiginizsehir.Text = Adres.Text;

            form2.Show();
        }
    }
}
