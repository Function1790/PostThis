
namespace PostThis
{
    partial class PostThis
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostThis));
            this.Move_Panel = new System.Windows.Forms.Panel();
            this.Set_Pb = new System.Windows.Forms.PictureBox();
            this.Buttons_Panel = new System.Windows.Forms.Panel();
            this.Close_Pb = new System.Windows.Forms.PictureBox();
            this.MovePanel_Sizealbe = new System.Windows.Forms.Timer(this.components);
            this.MovePanel_Keep = new System.Windows.Forms.Timer(this.components);
            this.Write_Box = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Move_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Set_Pb)).BeginInit();
            this.Buttons_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Move_Panel
            // 
            this.Move_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(192)))), ((int)(((byte)(231)))));
            this.Move_Panel.Controls.Add(this.Set_Pb);
            this.Move_Panel.Controls.Add(this.Buttons_Panel);
            this.Move_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Move_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.Move_Panel.Location = new System.Drawing.Point(0, 0);
            this.Move_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Move_Panel.Name = "Move_Panel";
            this.Move_Panel.Size = new System.Drawing.Size(253, 30);
            this.Move_Panel.TabIndex = 0;
            this.Move_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Move_Panel_Paint);
            this.Move_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Panel_MouseDown);
            this.Move_Panel.MouseLeave += new System.EventHandler(this.Move_Panel_MouseLeave);
            this.Move_Panel.MouseHover += new System.EventHandler(this.Move_Panel_MouseHover);
            this.Move_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_Panel_MouseMove);
            this.Move_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Panel_MouseUp);
            // 
            // Set_Pb
            // 
            this.Set_Pb.Image = ((System.Drawing.Image)(resources.GetObject("Set_Pb.Image")));
            this.Set_Pb.Location = new System.Drawing.Point(5, 5);
            this.Set_Pb.Name = "Set_Pb";
            this.Set_Pb.Size = new System.Drawing.Size(20, 20);
            this.Set_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Set_Pb.TabIndex = 1;
            this.Set_Pb.TabStop = false;
            this.Set_Pb.Click += new System.EventHandler(this.Set_Pb_Click);
            // 
            // Buttons_Panel
            // 
            this.Buttons_Panel.Controls.Add(this.Close_Pb);
            this.Buttons_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Buttons_Panel.Location = new System.Drawing.Point(223, 0);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.Size = new System.Drawing.Size(30, 30);
            this.Buttons_Panel.TabIndex = 1;
            this.Buttons_Panel.MouseLeave += new System.EventHandler(this.Move_Panel_MouseLeave);
            this.Buttons_Panel.MouseHover += new System.EventHandler(this.Move_Panel_MouseHover);
            // 
            // Close_Pb
            // 
            this.Close_Pb.Image = ((System.Drawing.Image)(resources.GetObject("Close_Pb.Image")));
            this.Close_Pb.Location = new System.Drawing.Point(5, 5);
            this.Close_Pb.Name = "Close_Pb";
            this.Close_Pb.Size = new System.Drawing.Size(20, 20);
            this.Close_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Pb.TabIndex = 0;
            this.Close_Pb.TabStop = false;
            this.Close_Pb.Click += new System.EventHandler(this.Close_Pb_Click);
            this.Close_Pb.MouseHover += new System.EventHandler(this.Move_Panel_MouseHover);
            // 
            // MovePanel_Sizealbe
            // 
            this.MovePanel_Sizealbe.Interval = 1;
            this.MovePanel_Sizealbe.Tick += new System.EventHandler(this.MovePanel_Sizealbe_Tick);
            // 
            // MovePanel_Keep
            // 
            this.MovePanel_Keep.Tick += new System.EventHandler(this.MovePanel_Keep_Tick);
            // 
            // Write_Box
            // 
            this.Write_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Write_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Write_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Write_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Write_Box.Location = new System.Drawing.Point(0, 30);
            this.Write_Box.Multiline = true;
            this.Write_Box.Name = "Write_Box";
            this.Write_Box.Size = new System.Drawing.Size(253, 316);
            this.Write_Box.TabIndex = 1;
            this.Write_Box.TextChanged += new System.EventHandler(this.Write_Box_TextChanged);
            // 
            // PostThis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(253, 346);
            this.Controls.Add(this.Write_Box);
            this.Controls.Add(this.Move_Panel);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PostThis";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostThis_KeyPress);
            this.Move_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Set_Pb)).EndInit();
            this.Buttons_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Move_Panel;
        private System.Windows.Forms.Timer MovePanel_Sizealbe;
        private System.Windows.Forms.Panel Buttons_Panel;
        private System.Windows.Forms.PictureBox Close_Pb;
        private System.Windows.Forms.Timer MovePanel_Keep;
        private System.Windows.Forms.TextBox Write_Box;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Set_Pb;
    }
}

