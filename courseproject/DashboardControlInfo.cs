using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace project1
{
    [Serializable]
    class DashboardControlInfo
    {
        public Point[][] locations = new Point[5][];
        public int fheight = 0;
        public bool dBoxVisibility = true;
        private void GetControlLocation(Control[] ctr, int ind)
        {
            locations[ind] = ctr
                .Select(obj => obj.Location)
                .ToArray();
        }
        private void SetControlLocation(Control[] ctr, int ind)
        {
            for (int i=0; i<3; i++)
                ctr[i].Location = locations[ind][i];
        }
        public void SetDbc(DashboardCustomizationControl dbc)
        {
            SetControlLocation(dbc.lbType, 0);
            SetControlLocation(dbc.lboxType, 1);
            SetControlLocation(dbc.rtbox, 2);
            SetControlLocation(dbc.bttnAdd, 3);
            dbc.bttnBin.Location = locations[4][0];
            dbc.bttnNotis.Location = locations[4][1];
            dbc.form.Height = fheight;
            foreach (var obj in dbc.rtbox)
                obj.Visible = dBoxVisibility;
        }
        public DashboardControlInfo()
        {
            
        }
        public DashboardControlInfo(DashboardCustomizationControl dbc)
        {
            GetControlLocation(dbc.lbType, 0);
            GetControlLocation(dbc.lboxType, 1);
            GetControlLocation(dbc.rtbox, 2);
            GetControlLocation(dbc.bttnAdd, 3);
            locations[4] = new Point[]{dbc.bttnBin.Location, dbc.bttnNotis.Location};
            dBoxVisibility = dbc.rtbox[0].Visible;
            fheight = dbc.form.Height;
        }
    }
}
