using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoliterBusinessLogic;

namespace Soliter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CardDrawer cardDrawer = new CardDrawer();

            cardDrawer.Picture = pictureBox1;
            var kingOfHearts = Card.KingOfHearts;
            

            


            cardDrawer.Card = kingOfHearts;
            cardDrawer.DrawCard();

            cardDrawer.Picture = pictureBox2;
            cardDrawer.DrawCard();


        }

        
    }
}
