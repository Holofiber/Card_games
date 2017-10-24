using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoliterBusinessLogic;

namespace Soliter
{

    class CardDrawer
    {
        public Card Card { get ; set; }
        public PictureBox Picture { get; set; }

        public void DrawCard()
        {
            Picture.Image = Image.FromFile("./Images/Cards/2_of_clubs.png");
        }
    }

    
}
