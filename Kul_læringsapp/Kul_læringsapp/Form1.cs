using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kul_læringsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] bilder = new string[10, 2];
        PictureBox[] pic = new PictureBox[9];
        Timer t = new Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            bilder[0, 0] = "Hund.jpg";
            bilder[0, 1] = "Hundtekst";
            pb1.Image = Image.FromFile("Løve.jpg");
            pb1.Enabled = false;
        }

        /// <summary>
        /// Hente inn 4 tilfeldige bilder og de skriftbildene som hører til
        /// og gi de tilfeldige referanseverdier slik at de enkelt kan legges inn i picturbox'ene.
        /// Hente inn ett bilde og gi det den siste plassen.
        /// Sette 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
         //Dette er en test xoxxox   
        }


        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
