using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void generate_alphabet_B_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 main = this.Owner as Form1;
                main.generate_alphabet();
                MessageBox.Show("Алфавит был успешно сгенерирован", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.. попробуйте снова", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
