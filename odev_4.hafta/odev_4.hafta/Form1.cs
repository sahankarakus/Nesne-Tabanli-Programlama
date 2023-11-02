namespace odev_4.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> kullaniciadi_list = new List<string>();
        List<string> sifre_list = new List<string>();
        int kisi_sayac;
        Boolean konrtol;

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kullaniciadi_list.Count(); i++)
            {
                if (kullaniciadi_list[i] == textBox1.Text)
                {
                    konrtol = true;
                }
            }
            if (konrtol == true)
            {
                MessageBox.Show("Bu Kullanýcý Adý Kullanýlýyor");
            }
            else
            {
                MessageBox.Show("Kayýt Baþarýlý");
                kullaniciadi_list.Add(textBox1.Text);
                sifre_list.Add(textBox2.Text);
                kisi_sayac++;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
            {
                listBox1.Items.Clear();
                for (int i = 0; i < kisi_sayac; i++)
                {
                    string kullanici = kullaniciadi_list[i] + " " + sifre_list[i];
                    listBox1.Items.Add(kullanici);
                }
            }
            else
            {
                for (int i = 0; i < kisi_sayac; i++)
                {
                    string kullanici = kullaniciadi_list[i] + "" + sifre_list[i];
                    listBox1.Items.Add(kullanici);
                }
            }

        }
    }
}