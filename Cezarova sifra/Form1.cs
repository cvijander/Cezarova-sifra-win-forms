namespace Cezarova_sifra
{
    public partial class Form1 : Form
    {
        private bool odabran = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void odaberiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tekstualni dokument (*.txt) |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                odabran = true;
                label1.Text = ofd.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Molimo odaberite fajl";
        }

        private void zakljucajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odabran == true)
            {
                string sadrzaj = File.ReadAllText(label1.Text);
                string noviSadrzaj = Zakljucaj(sadrzaj);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Tekstualni dokument (*.txt) |*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, noviSadrzaj);
                    MessageBox.Show("Fajl je uspesno zakljucan");
                }
            }
            else
            {
                MessageBox.Show("Greska niste odabrali fajl");
            }
        }

        private string Zakljucaj(string sadrzaj)
        {
            //"Ab cd" -> "Bc de"  cezarova sifra
            string noviString = "";
            foreach (char x in sadrzaj)
            {
                if (Char.IsUpper(x) && x != 'Z') noviString += (char)(x + 1);
                else if (x == 'Z') noviString += 'A';
                else if (Char.IsLower(x) && x != 'z') noviString += (char)(x + 1);
                else if (x == 'z') noviString += 'a';
                else noviString += x;
            }
            return noviString;
        }

        private void otkljucajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odabran == true)
            {
                string sadrzaj = File.ReadAllText(label1.Text);
                string noviSadrzaj = Otkljucaj(sadrzaj);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Tekstualni dokument (*.txt) |*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, noviSadrzaj);
                    MessageBox.Show("Fajl je uspesno otkljucan");
                }
            }
            else
            {
                MessageBox.Show("Greska niste odabrali fajl");
            }
        }

        private string Otkljucaj(string sadrzaj)
        {
            //"Ab cd" -> "Bc de"  cezarova sifra
            string noviString = "";
            foreach (char x in sadrzaj)
            {
                if (Char.IsUpper(x) && x != 'A') noviString += (char)(x - 1);
                else if (x == 'A') noviString += 'Z';
                else if (Char.IsLower(x) && x != 'a') noviString += (char)(x - 1);
                else if (x == 'a') noviString += 'z';
                else noviString += x;
            }
            return noviString;
        }
    }
}