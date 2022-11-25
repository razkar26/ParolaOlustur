using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParolaOlustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void PasswordFormed()
        {
            Random rnd = new Random();
            string highChase = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string lowerChase = "qwertyuıopğüasdfghjklşizxcvbnmöç";
            string numChase = "0123456789";
            string ofsetChase = "<>!^#+$%&/{[(])=}?*-_;,:.@";
            string result = "";
            int leng = Convert.ToInt16(nUpDown.Value.ToString());//Numeric Up Down value degerini string çeviriyoruz daha sonra int çeviriyoruz.
            if (chbHigh.Checked == false && chbLower.Checked == false && chbNum.Checked == false && chbOfset.Checked == false)
            {
                MessageBox.Show("Bütün kutucuklar boş olamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (chbHigh.Checked)
                { result += highChase; }
                if (chbLower.Checked)
                { result += lowerChase; }
                if (chbNum.Checked)
                { result += numChase; }
                if (chbOfset.Checked)
                { result += ofsetChase; }
                for (int i = 0; i < leng; i++)
                {
                    txtMake.Text += result[rnd.Next(result.Length)];
                }

            }
        }
        private void btnForm_Click(object sender, EventArgs e)
        {
            txtMake.Clear();
            PasswordFormed();
        }
    }
}
