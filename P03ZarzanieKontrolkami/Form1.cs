using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZarzanieKontrolkami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>();
            foreach (Control item in Controls)
                controls.Add(item);
            controls.Add(this);


            //var kontrolki = Controls;
            //kontrolki.Add(this);
            foreach (Control item in controls)
            {
                if (!(item is Button))
                {
                    
                    //item.Visible = false;
                }
                
                MessageBox.Show(item.Name);
            }

            //textBox1.Visible = false;
            //textBox2.Visible = false;
            //comboBox1.Visible = false;



        }
    }
}
