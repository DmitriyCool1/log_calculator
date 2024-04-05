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


//2.1.Калькуляторы
//1) Разработать класс «Калькулятор», выполняющий указанные в варианте
//операции для заданных исходных данных. Программа должна выполнять ввод
//данных, проверку правильности введенных данных, выдачу соответствующих
//сообщений в случае возникновения ошибок.
//2)Протокол работы калькулятора записать в файл. Протокол должен
//включать исходные данные, введенные пользователем, выполняемые операции
//и результаты их выполнения. В случае возникновения ошибки в файл
//записывается соответствующее сообщение.
//3)Предусмотреть возможность просмотра этого файла из программы
//калькулятора.

//10. Логарифмы чисел при различных
//основаниях.

//Сложение,
//вычитание,
//умножение,
//деление,
//возведение в степень,
//переход к другому основанию.

namespace CalcLog_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonСложение.Checked = true;
        }
        //private void button11_Click(object sender, EventArgs e)
        //{
        //    //if ((double.Parse(richTextBox1.Text) < 0) || (double.Parse(richTextBox11.Text) == 1) || (double.Parse(richTextBox11.Text) < 0))
        //    //{
        //    //    MessageBox.Show("Ввод логарифма не соответсвует его ОДЗ", "Ошибка при ввводе логарифма", MessageBoxButtons.OKCancel MessageBoxIcon.Error);
        //    //}
        //    richTextBox111.Text = Convert.ToString(Math.Log(double.Parse(richTextBox1.Text), double.Parse(richTextBox11.Text)));
        //    richTextBox222.Text = Convert.ToString(Math.Log(double.Parse(richTextBox2.Text), double.Parse(richTextBox22.Text)));


        //}
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox111.Text = Convert.ToString(Math.Log(double.Parse(richTextBox1.Text), double.Parse(richTextBox11.Text)));
            richTextBox222.Text = Convert.ToString(Math.Log(double.Parse(richTextBox2.Text), double.Parse(richTextBox22.Text)));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonСложение_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonВычитание_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonУмножение_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonДеление_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonСтепень_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonОснование_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonСчет_Click(object sender, EventArgs e)
        {
            if (radioButtonСложение.Checked == true)
            {
                string ch1 = richTextBox111.Text;
                string ch2 = richTextBox222.Text;
                Kalkulator sl1 = new Kalkulator { value = ch1 };
                Kalkulator sl2 = new Kalkulator { value = ch2 };
                Kalkulator sl3 = sl1 + sl2;
                richTextBox3.Text = Convert.ToString(sl3.value);
                //Protocol.Recording("", ch1, ch2, "+", sl3.value);
            }
            if (radioButtonВычитание.Checked == true)
            {
                string ch1 = richTextBox111.Text;
                string ch2 = richTextBox222.Text;
                Kalkulator sl1 = new Kalkulator { value = ch1 };
                Kalkulator sl2 = new Kalkulator { value = ch2 };
                Kalkulator sl3 = sl1 - sl2;
                richTextBox3.Text = Convert.ToString(sl3.value);
                //Protocol.Recording("", ch1, ch2, "-", sl3.value);

            }
            if (radioButtonУмножение.Checked == true)
            {
                string ch1 = richTextBox111.Text;
                string ch2 = richTextBox222.Text;
                Kalkulator sl1 = new Kalkulator { value = ch1 };
                Kalkulator sl2 = new Kalkulator { value = ch2 };
                Kalkulator sl3 = sl1 * sl2;
                richTextBox3.Text = Convert.ToString(sl3.value);
                //Protocol.Recording("", ch1, ch2, "*", sl3.value);
            }
            if (radioButtonДеление.Checked == true)
            {
                string ch1 = richTextBox111.Text;
                string ch2 = richTextBox222.Text;
                Kalkulator sl1 = new Kalkulator { value = ch1 };
                Kalkulator sl2 = new Kalkulator { value = ch2 };
                Kalkulator sl3 = sl1 / sl2;
                richTextBox3.Text = Convert.ToString(sl3.value);
                //Protocol.Recording("", ch1, ch2, "/", sl3.value);
            }
            if (radioButtonСтепень.Checked == true)
            {
                ;
                string ch1 = richTextBox111.Text;
                string ch2 = richTextBox222.Text;
                Kalkulator sl1 = new Kalkulator { value = ch1 };
                Kalkulator sl2 = new Kalkulator { value = ch2 };
                Kalkulator sl3 = Math.Pow(sl1, sl2);
                richTextBox3.Text = Convert.ToString(sl3.value);
                //Protocol.Recording("", ch1, ch2, "%", sl3.value);
            }
            if (radioButtonОснование.Checked == true)
            {
                ;
                string ch1 = richTextBox111.Text;
                string ch2 = richTextBox222.Text;
                Kalkulator sl1 = new Kalkulator { value = ch1 };
                Kalkulator sl2 = new Kalkulator { value = ch2 };
                Kalkulator sl3 = sl1 / sl2;
                richTextBox3.Text = Convert.ToString(sl3.value);
                //Protocol.Recording("", ch1, ch2, "%", sl3.value);
            }
        }

        private void buttonОчистить_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
         class Kalkulator
         {
            public string value;
            public static Kalkulator operator +(Kalkulator ch1, Kalkulator ch2)
            {
                return new Kalkulator { value = Convert.ToString(ch1 + ch2) };
            }


        }
        class Protocol
        {
            public static string Recording(string text, string ch1, string ch2, string op, string ch3)
            {
                FileStream file = new FileStream("protocol.txt", FileMode.Append);
                StreamWriter f = new StreamWriter(file);
                f.Write(ch1 + op + ch2 + "=" + ch3 + "\n");
                f.Close();
                return text;
            }
            public static string RecordingExceptions(string text)
            {
                FileStream file = new FileStream("protocol.txt", FileMode.Append);
                StreamWriter f = new StreamWriter(file);
                f.Write(text + "\n");
                f.Close();
                return text;
            }
            public static string Reading()
            {
                FileStream file = new FileStream("protocol.txt", FileMode.Append);
                StreamWriter f = new StreamWriter(file);
                f.Close();
                string[] massiv = System.IO.File.ReadAllLines("protocol.txt");
                string s = File.ReadAllLines("protocol.txt").Last();
                f.Close();
                return Convert.ToString(s);
            }
           
        }

        private void инструкцияДляПримененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы воспользоваться калькулятором необходимо: 1.Внести значения оснований и сами значения логарифма; " +
                "2.Нажать на кнопку<Исходные значения логарифмов>" +
                "3.Выбрать операцию; 4.Нажать кнопку <Вычислить> ","Инструкция", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По всем вопросам связанным с работой калькулятора обращаться на почту: qwerty12345@gmail.com ", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void прочестьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("protocol.txt") == false)
            {
                throw new System.IO.FileNotFoundException("Файла истории не существует. Совершите операцию, чтобы он появился!");
            }
            string[] text = System.IO.File.ReadAllLines("protocol.txt");
            comboBox1.Items.AddRange(text);
        }

        private void buttonДозагрузка_Click(object sender, EventArgs e)
        {

        }

        private void удалитьЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("protocol.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
