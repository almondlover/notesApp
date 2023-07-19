using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace project1
{
    class DashboardCustomizationControl
    {
        public Label[] lbType=new Label[3];
        public ListBox[] lboxType = new ListBox[3];
        public RichTextBox[] rtbox = new RichTextBox[3];
        public Button[] bttnAdd = new Button[3];
        public Button bttnNotis = new Button();
        public Button bttnBin = new Button();
        public Form form = new Form();
        public static void Swap(Control ctr1, Control ctr2)
        {
            var temp = ctr1.Location;
            ctr1.Location = ctr2.Location;
            ctr2.Location = temp;
        }
        public void SwapTypeControlPlaces(int ind1, int ind2)
        {
            Swap(lbType[ind1], lbType[ind2]);
            Swap(lboxType[ind1], lboxType[ind2]);
            Swap(rtbox[ind1], rtbox[ind2]);
            Swap(bttnAdd[ind1], bttnAdd[ind2]);
        }
        public void ToggleDescriptionBoxesVisibility()
        {
            for (int i = 0; i < 3; i++)
            {
                rtbox[i].Visible = !rtbox[i].Visible;
                bttnAdd[i].Top = bttnAdd[i].Location.Y+(!rtbox[i].Visible ? -1:1)*rtbox[i].Height;
            }
            bttnNotis.Top = bttnNotis.Location.Y + (!rtbox[0].Visible ? -1 : 1) * rtbox[0].Height;
            bttnBin.Top = bttnBin.Location.Y + (!rtbox[0].Visible ? -1 : 1) * rtbox[0].Height;
            form.Height+= (!rtbox[0].Visible ? -1 : 1) * rtbox[0].Height;

        }

    }
}
