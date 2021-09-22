using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostThis
{
    public partial class Data_Modify : Form
    {
        Point pos;

        public Data_Modify(string[] values,Point pos)
        {
            InitializeComponent();
            Width_Box.Text = values[0];
            Height_Box.Text = values[1];
            SetDesktopLocation(pos.X, pos.Y);
            this.pos = pos;
        }

        public string[] Info_Value
        {
            get
            {
                string[] values = { Width_Box.Text, Height_Box.Text };
                return values;
            }
            set
            {
                Width_Box.Text = value[0];
                Height_Box.Text = value[1];
            }
        }

        private void Data_Modify_Load(object sender, EventArgs e)
        {
            SetDesktopLocation(pos.X-Width-10, pos.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] values = { Width_Box.Text, Height_Box.Text };
            Info_Value = values;
            Close();
        }

        bool Move_Clicked = false;
        Point Clicked_Pos = new Point(0, 0);
        private void Move_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Move_Clicked = false;
        }

        private void Move_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move_Clicked == true)
            {
                SetDesktopLocation(MousePosition.X - Clicked_Pos.X, MousePosition.Y - Clicked_Pos.Y);
            }
        }

        private void Move_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Clicked_Pos = new Point(e.X, e.Y);
            Move_Clicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
