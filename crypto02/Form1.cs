using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace crypto02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_watermark();
            get_alphabet();
        }

        private void init_watermark()
        {
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Type the string here...";
            textBox1.Leave += new EventHandler(textBox1_Leave);
            textBox1.Enter += new EventHandler(textBox1_Enter);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Type the string here...";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Type the string here...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private Dictionary<byte, byte> alph_encode = new Dictionary<byte, byte>();
        private Dictionary<byte, byte> alph_decode = new Dictionary<byte, byte>();
        private string alph_base = "йцукенгшщзхъфывапролджэячсмитьбю";

        public void generate_alphabet()
        {
            byte[] alph00 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            this.alph_encode.Clear();
            this.alph_decode.Clear();

            byte[] x = new byte[16];
            for (byte i = 1; i <= 16; i++)
                x[i - 1] = i;

            Random random = new Random(DateTime.Now.Millisecond);
            x = x.OrderBy(xxx => random.Next()).ToArray();

            for (byte i = 1; i <= 16; i++)
            {
                alph_encode.Add(i, x[i - 1]);
            }
            alph_decode = alph_encode.ToDictionary(xxx => xxx.Value, xxx => xxx.Key);

            using (StreamWriter al = new StreamWriter(new FileStream("tech", FileMode.Create)))
            {
                foreach (var zzz in alph_encode)
                    al.WriteLine("{0} {1}", zzz.Key, zzz.Value);
                foreach (var zzz in alph_decode)
                    al.WriteLine("{0} {1}", zzz.Key, zzz.Value);
            }
        }
        private void get_alphabet()
        {
            using (StreamReader al = new StreamReader(new FileStream("tech", FileMode.Open)))
            {
                this.alph_encode.Clear();
                this.alph_decode.Clear();

                string[] temp;
                char[] sep = { ' ' };
                for (byte i = 0; i < 16; i++)
                {
                    temp = al.ReadLine().Split(sep);
                    alph_encode.Add(Convert.ToByte(temp[0]), Convert.ToByte(temp[1]));
                }
                for (byte i = 0; i < 16; i++)
                {
                    temp = al.ReadLine().Split(sep);
                    alph_decode.Add(Convert.ToByte(temp[0]), Convert.ToByte(temp[1]));
                }
            }
        }
        private bool check_text(byte[] buffer)
        {
            for (byte i = 0; i < buffer.Count(); i++)
            {
                if (buffer[i] < 192)
                {
                    MessageBox.Show("Данные содержат элементы, отсутствующие в алфавите", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text); // copy to windows clipboard
        }

        private void encrypt_B_Click(object sender, EventArgs e)
        {
            // йцукенгшщзхъфывапролджэячсмитьбю
            textBox2.Text = "";
            byte[] buffer = new byte[textBox1.Text.Length];
            Encoding win1251 = Encoding.GetEncoding("windows-1251");
            buffer = win1251.GetBytes(textBox1.Text);
            if (check_text(buffer))
                return;                                         // проверка на алфавит
            
            byte cnt = Convert.ToByte(textBox1.Text.Length);    // длина текста
            byte cnt_lb = Convert.ToByte(cnt % 16);             // количество символов в последнем блоке
            byte cnt_b = 0;
            if (cnt_lb == 0)
                cnt_b = Convert.ToByte(cnt / 16);               // количество блоков
            else
                cnt_b = Convert.ToByte(cnt / 16 + 1);
            List<string> blocks = new List<string>();           // блоки исходного текста
            List<string> blocks_e = new List<string>();         // блоки кодированного текста

            string temp = textBox1.Text;
            byte last_char;                                     // кол-во доп. симв. для последнего блока
            for (last_char = 0; last_char < 16 - cnt_lb; last_char++)
                temp += Convert.ToString(alph_base[last_char]);

            for (byte i = 0; i < cnt_b; i++)
                blocks.Add(temp.Substring(i * 16, 16));         // разделение на блоки

            for (byte i = 0; i < blocks.Count; i++)
            {
                temp = "";
                for (byte j = 0; j < 16; j++)
                    temp += blocks[i][alph_encode[Convert.ToByte(j + 1)] - 1];
                blocks_e.Add(temp);                             // перестановки (кодирование)
            }

            textBox2.Text += Convert.ToString(alph_base[last_char - 1]);
            foreach (string x in blocks_e)
                textBox2.Text += x;

            //var str = win1251.GetString(buffer);
        }

        private void decrypt_B_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            byte[] buffer = new byte[textBox1.Text.Length];
            Encoding win1251 = Encoding.GetEncoding("windows-1251");
            buffer = win1251.GetBytes(textBox1.Text);
            if (check_text(buffer))
                return;                                         // проверка на алфавит

            char last_char_c = textBox1.Text[0];                // первый символ, решающий все
            byte last_char = 0;                                 // количество добавленных символов
            for (byte i = 0; i < alph_base.Length; i++)
                if (last_char_c == alph_base[i])
                {
                    last_char = Convert.ToByte(i + 1);
                    break;
                }
            List<string> blocks_e = new List<string>();         // блоки кодированного текста
            List<string> blocks_d = new List<string>();         // блоки декодированного текста

            string temp = textBox1.Text;                        // кодированный текст
            temp = temp.Substring(1);                           // реальный кодированный текст
            byte cnt_b = Convert.ToByte(temp.Length / 16);      // количество блоков
            for (byte i = 0; i < cnt_b; i++)
                blocks_e.Add(temp.Substring(i * 16, 16));       // разделение на блоки
            
            for (byte i = 0; i < blocks_e.Count; i++)
            {
                temp = "";
                for (byte j = 0; j < 16; j++)
                    temp += blocks_e[i][alph_decode[Convert.ToByte(j + 1)] - 1];
                blocks_d.Add(temp);                             // перестановки (декодирование)
            }
            blocks_d.Remove(temp);
            temp = temp.Substring(0, temp.Length - last_char);
            blocks_d.Add(temp);

            foreach (string x in blocks_d)
                textBox2.Text += x;
        }

        private void more_options_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }
    }
}
