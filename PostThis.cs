using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostThis
{
    public partial class PostThis : Form
    {
        /*--Variable--*/
        int[] Size_Height = { 10, 30 };
        int[] Control_Y = { -20, 5 };
        bool Move_Clicked = false;
        Point Clicked_Pos = new Point(0, 0);
        int Sizeable_Mode = 1;
        int Wait_Dalay = 0;
        string[] info = new string[4];
        bool error = false;

        /*--Function--*/
        public PostThis()
        {
            InitializeComponent();
        }

        int ToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        void Log(string title, string content)
        {
            Console.WriteLine($"[{title}] : {content}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File_Load();
            Set_Sizeable(0);

            Location = new Point(ToInt(info[0]), ToInt(info[1]));
            Size = new Size(ToInt(info[2]), ToInt(info[3]));
        }
        private void Close_Pb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Move_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Move_Clicked = false;
        }

        private void Move_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move_Clicked == true)
            {
                SetDesktopLocation(MousePosition.X - Clicked_Pos.X, MousePosition.Y - Clicked_Pos.Y);
                Info_Save();
            }
        }

        private void Move_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Clicked_Pos = new Point(e.X, e.Y);
            Move_Clicked = true;
        }

        private void Move_Panel_MouseLeave(object sender, EventArgs e)
        {
            MovePanel_Keep.Start();
        }

        private void Move_Panel_MouseHover(object sender, EventArgs e)
        {
            Set_Sizeable(1);
            Wait_Dalay = 0;
            MovePanel_Keep.Stop();
        }

        private void MovePanel_Sizealbe_Tick(object sender, EventArgs e)
        {
            int Add_Value = 3;
            Point Close_Pos = Close_Pb.Location;
            if (Sizeable_Mode == 0)
            {
                Set_MovePanel_Location(-Add_Value, Move_Panel.Height > Size_Height[0], Close_Pos.Y > Control_Y[0]);
            }
            else if (Sizeable_Mode == 1)
            {
                Set_MovePanel_Location(Add_Value, Move_Panel.Height < Size_Height[1], Close_Pos.Y < Control_Y[1]);
            }
        }

        protected void Set_Sizeable(int Mode)
        {
            Sizeable_Mode = Mode;
            MovePanel_Sizealbe.Start();
        }

        protected void Set_Button_Pos(Control Btn, int Add_Value)
        {
            Point Btn_Pos = Btn.Location;
            Btn.Location = new Point(Btn_Pos.X, Btn_Pos.Y + Add_Value);
        }

        protected void Set_MovePanel_Location(int Add_Value, bool Move_Panel_Height, bool Close_Pos_Y)
        {
            if (Close_Pos_Y == true)
            {
                Set_Button_Pos(Close_Pb, Add_Value);
                Set_Button_Pos(Set_Pb, Add_Value);
            }
            if (Move_Panel_Height == true)
            {
                Move_Panel.Height += Add_Value;
            }
        }

        private void MovePanel_Keep_Tick(object sender, EventArgs e)
        {
            if (Wait_Dalay < 5)
            {
                Wait_Dalay++;
            }
            else
            {
                Sizeable_Mode = 0;
            }
        }

        private void PostThis_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void File_Save()
        {
            StreamWriter memo = new StreamWriter(@"Memo.txt");
            memo.WriteLine(Write_Box.Text);
            memo.Close();
        }
        public void Info_Set()
        {
            //x, y, width, height
            info[0] = Location.X + "";
            info[1] = Location.Y + "";
            info[2] = Width + "";
            info[3] = Height + "";
        }

        public void Info_Save()
        {
            Info_Set();
            try
            {
                StreamWriter info_file = new StreamWriter(@"Info.txt");
                for (int i = 0; i < info.Length; i++)
                {
                    info_file.WriteLine(info[i]);
                }
                info_file.Close();
            }
            catch(Exception e)
            {
                Log("Error", "Exception");
            }
        }

        void Load_Error()
        {
            Size = new Size(253, 346);
            Location = new Point(50, 50);
            Info_Set();
        }

        public void File_Load()
        {
            try
            {
                Write_Box.Text = File.ReadAllText(@"Memo.txt");
                StreamReader info_file = new StreamReader("Info.txt");
                for (int i = 0; i < info.Length; i++)
                {
                    info[i] = info_file.ReadLine();
                    Log("Load", info[i]+"");
                }
                for (int i = 2; i < info.Length; i++)
                {
                    int a = ToInt(info[i]);
                    if (a == 0)
                    {
                        Log("Error", "Info_Value");
                        Load_Error();
                        Info_Set();
                        break;
                    }
                }
                info_file.Close();
            }
            catch (FileNotFoundException e)
            {
                Log("Error", "FileNotFoundException");
                FileStream f = File.Create(@"Memo.txt");
                FileStream f2 = File.Create(@"Info.txt");
                Load_Error();
            }
        }

        private void Write_Box_TextChanged(object sender, EventArgs e)
        {
            File_Save();
        }

        private void Move_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        public string[] Info_Value
        {
            get
            {
                string[] values = { info[2], info[3] };
                return values;
            }
            set
            {
                info[2] = value[0];
                info[3] = value[1];
            }
        }

        private void Set_Pb_Click(object sender, EventArgs e)
        {
            string[] values = { info[2], info[3] };
            Data_Modify setting = new Data_Modify(values,Location);
            setting.Location = Location;
            setting.ShowDialog();
            values = setting.Info_Value;
            Width = ToInt(values[0]);
            Height = ToInt(values[1]);
            Info_Save();
        }
    }
}
