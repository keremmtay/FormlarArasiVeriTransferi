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
    public partial class Form2 : Form
    {

        // Farklı bir form üzerinden bu forma bir veri taşımak istiyorsak, öncelikle class seviyesinde bir değişken ya da property tanımlamamız gerekiyor. Burada tek bir şart var o da tanımlanan değişken ya da kesinlikle public olmalı. Aksi takdirde bu değişkene ulaşamayız.
        // Bu formu açmak istediğimiz noktada bu formdan bir instance/örnek/nesne almalıyız. Yani bu formu new'lememiz gerekir. Bu durumda burada tanımladığımız değişkene de ulaşabiliriz.

        public string Adi { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Property'e set edilen veriyi label'ın text'ine atarak kullanmış olduk. Farklı amaçlar için de bu şekilde bir veriyi farklı bir forma göndererek ihtiyaçlarımız doğrultusunda kullanabiliriz.

            label2.Text = Adi;
        }
    }
}
