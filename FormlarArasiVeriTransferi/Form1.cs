using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriTransferi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bir form içerisinden (Form1) başka bir form (Form2) açmak istediğimizde öncelikle açmak istediğimiz formdan(Form2) bir nesne oluşturmamız gerekecek.

            Form2 form2 = new Form2();

            form2.BackColor = Color.CornflowerBlue;

            // Aşağıda Form2 içinde tanımlı olan property'e textbox içindeki verimizi set ettik. Ve böylece Form1'de olan verimiz Form2'ye taşınmış oldu.

            form2.Adi = textBox1.Text;

            //form2.Show(); // Show() ile ilgili formu istediğimiz sayıda açabiliyoruz.

            form2.ShowDialog(); // Form1'e dönmek için öncelikli olarak açılan Form2'yi kapatmamız gerekiyor.
        }
    }
}
