using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_dimensional_array
{
    public partial class Form1 : Form
    {
        int[] array = new int[15];
        public Form1()
        {
            InitializeComponent();
        }
        Funcs funcs = new Funcs();
        private void button1_Click(object sender, EventArgs e)
        {
            array[0] = Convert.ToInt16(tb1.Text);
            array[1] = Convert.ToInt16(tb2.Text);
            array[2] = Convert.ToInt16(tb3.Text);
            array[3] = Convert.ToInt16(tb4.Text);
            array[4] = Convert.ToInt16(tb5.Text);
            array[5] = Convert.ToInt16(tb6.Text);
            array[6] = Convert.ToInt16(tb7.Text);
            array[7] = Convert.ToInt16(tb8.Text);
            array[8] = Convert.ToInt16(tb9.Text);
            array[9] = Convert.ToInt16(tb10.Text);
            array[10] = Convert.ToInt16(tb11.Text);
            array[11] = Convert.ToInt16(tb12.Text);
            array[12] = Convert.ToInt16(tb12.Text);
            array[13] = Convert.ToInt16(tb14.Text);
            array[14] = Convert.ToInt16(tb15.Text);

            for (int i = 0; i < array.Length; i++)
                arrayout.Text += array[i] + " ";

            array=Funcs.Sort(array);
            for (int i = 0; i < array.Length; i++)
                result.Text += array[i] + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            array = null;
            result.Text = null;
            arrayout.Text = null;
            tb1.Text = null;
            tb2.Text = null;
            tb3.Text = null;
            tb4.Text = null;
            tb5.Text = null;
            tb6.Text = null;
            tb7.Text = null;
            tb8.Text = null;
            tb9.Text = null;
            tb10.Text = null;
            tb11.Text = null;
            tb12.Text = null;
            tb13.Text = null;
            tb14.Text = null;
            tb15.Text = null;
        }
    }
    }
