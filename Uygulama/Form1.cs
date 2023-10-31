namespace Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int[] sonuc = new int[6];
        private void button1_Click(object sender, EventArgs e)
        {

            for (int sayi = 0; sayi < sonuc.Length; sayi++)
            {
                int rastgeleSayi;
                do
                {
                  rastgeleSayi = rnd.Next(1, 36);
                } while (Array.IndexOf(sonuc, rastgeleSayi) != -1);
                sonuc[sayi] = rastgeleSayi;
            }
            Array.Sort(sonuc);
            button2.Text = sonuc[0].ToString();
            button3.Text = sonuc[1].ToString();
            button4.Text = sonuc[2].ToString();
            button5.Text = sonuc[3].ToString();
            button6.Text = sonuc[4].ToString();
            button7.Text = sonuc[5].ToString();
        }
    }
}