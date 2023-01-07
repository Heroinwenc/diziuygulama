using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizisoru1form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int rndsayi;
        char rndchar;
        private void button1_Click(object sender, EventArgs e)
        {

            rndsayi = rnd.Next(1, 10);
            rndchar = (char)rnd.Next(65, 91);
            char[] dizi2 = new char[rndchar];
            int[] dizi1 = new int[rndsayi];
            listBox1.Items.Clear();
            for (int i = 0; i < rndsayi; i++)
            {
                dizi1[i] = Convert.ToInt32(rnd.Next(1, 100));
                listBox1.Items.Add(dizi1[i]);
            }
            for (int i = 0; i < rndchar; i++)
            {
                dizi2[i] = Convert.ToChar(rnd.Next(65, 91));
                listBox1.Items.Add(dizi2[i]);
            }



        }
        int tiklama = 0;
        int index = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tiklama++;
            if (tiklama == 1)
            {
                string degistir = Interaction.InputBox("Dizi Eleman Değiştirme", "Yeni İfadeyi Giriniz\n\n Örn: Ahmet", "", 300, 300);
                int[] yedekdizi = new int[rndsayi];
                if (degistir == "")
                {
                    MessageBox.Show("Değiştirilemedi! Lütfen Değer Giriniz.");
                }
                else
                {
                    index = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Insert(index, degistir);
                    MessageBox.Show("Değiştirildi: " + degistir);
                }
                tiklama = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int[] yedekdizi2 = new int[rndsayi];
            for (int i = 0; i < rndsayi; i++)
            {
                textBox1.Text += listBox1.Items[i];
                textBox1.Text += ", ";
            }
            for (int i = 0; i < rndchar; i++)
            {
                textBox1.Text += listBox1.Items[i];
                textBox1.Text += ", ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string[] itemler = textBox1.Text.Split(',');
            //foreach (string item in itemler)
            //{
            //    listBox2.Items.Add(item);
            //}
            listBox2.Items.AddRange(textBox1.Text.Split(','));
        }
    }
}