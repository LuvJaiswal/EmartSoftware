﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emart
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;


            cmbitems.Items.Clear();
            cmbitems.Items.Add("silk kurtha");
            cmbitems.Items.Add("siphon kurtha");
            cmbitems.Items.Add("cotton kurtha");
            cmbitems.Items.Add("karai kurtha");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { 
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton1.ForeColor = System.Drawing.Color.Red;


            cmbitems.Items.Clear();
            cmbitems.Items.Add("simple Lehnga");
            cmbitems.Items.Add("karai Lehnga");
            cmbitems.Items.Add("Plain Lehnga");
            cmbitems.Items.Add("Bridal Lehnga");


        }

        private void cmbitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbitems.SelectedItem.ToString() == "silk kurtha")
            {
                textBox1.Text = "50";
            }

            else if (cmbitems.SelectedItem.ToString() == "siphon kurtha")
            {
                textBox1.Text = "150";
            }

            else if (cmbitems.SelectedItem.ToString() == "cotton kurtha")
            {
                textBox1.Text = "250";
            }


            else if (cmbitems.SelectedItem.ToString() == "karai kurtha")
            {
                textBox1.Text = "450";
            }

            else if (cmbitems.SelectedItem.ToString() == "simple Lehnga")
            {
                textBox1.Text = "1050";
            }


            else if (cmbitems.SelectedItem.ToString() == "Karai Lehnga")
            {
                textBox1.Text = "2050";
            }


            else if (cmbitems.SelectedItem.ToString() == "Plain Lehnga")
            {
                textBox1.Text = "3350";
            }


            else if (cmbitems.SelectedItem.ToString() == "Bridal Lehnga")
            {
                textBox1.Text = "5550";
            }
            else
            {
                textBox1.Text = "0";
            }


        }

        private void totaltext_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            totaltext.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
    }