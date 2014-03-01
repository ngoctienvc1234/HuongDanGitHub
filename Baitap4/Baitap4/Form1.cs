using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baitap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBoxX.Text = e.X.ToString();
            textBoxY.Text = e.Y.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string suKien = "";
            // Neu bam nut trai chuot
            if (e.Button == MouseButtons.Left)
            {
                suKien = "Left mouse click at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            // Neu bam nut phai chuot
            else if (e.Button == MouseButtons.Right)
            {
                suKien = "Right mouse click at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            listBoxEvents.Items.Add(suKien);
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            string suKien = "Mouse enter";
            listBoxEvents.Items.Add(suKien);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            string suKien1 = "Mouse Leave";
            listBoxEvents.Items.Add(suKien1);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            string suKien2 = "Mouse Hover";
            listBoxEvents.Items.Add(suKien2);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string suKien = "";
            // Neu bam nut trai chuot
            if (e.Button == MouseButtons.Left && e.Button == MouseButtons.Left)
            {
                suKien = "Left mouse double click at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            // Neu bam nut phai chuot
            else if (e.Button == MouseButtons.Right && e.Button == MouseButtons.Right)
            {
                suKien = "Right mouse double click at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            listBoxEvents.Items.Add(suKien);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            string suKien = "";
            // Neu bam nut trai chuot
            if (e.Button == MouseButtons.Left)
            {
                suKien = "Left mouse up at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            // Neu bam nut phai chuot
            else if (e.Button == MouseButtons.Right)
            {
                suKien = "Right mouse up at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            listBoxEvents.Items.Add(suKien);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            string suKien = "";
            // Neu bam nut trai chuot
            if (e.Button == MouseButtons.Left)
            {
                suKien = "Left mouse down at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            // Neu bam nut phai chuot
            else if (e.Button == MouseButtons.Right)
            {
                suKien = "Right mouse down at " + e.X.ToString() + "," +
                e.Y.ToString();
            }
            listBoxEvents.Items.Add(suKien);
        }


        

       
      
    }
}
