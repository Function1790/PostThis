
namespace PostThis
{
    partial class Data_Modify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Modify));
            this.Move_Panel = new System.Windows.Forms.Panel();
            this.Height_label = new System.Windows.Forms.Label();
            this.Width_label = new System.Windows.Forms.Label();
            this.Width_Box = new System.Windows.Forms.TextBox();
            this.Height_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Move_Panel
            // 
            this.Move_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(90)))));
            this.Move_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Move_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.Move_Panel.Location = new System.Drawing.Point(0, 0);
            this.Move_Panel.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Move_Panel.Name = "Move_Panel";
            this.Move_Panel.Size = new System.Drawing.Size(242, 10);
            this.Move_Panel.TabIndex = 1;
            this.Move_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Panel_MouseDown);
            this.Move_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_Panel_MouseMove);
            this.Move_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Panel_MouseUp);
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Location = new System.Drawing.Point(21, 49);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(56, 19);
            this.Height_label.TabIndex = 2;
            this.Height_label.Text = "Height";
            // 
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.Location = new System.Drawing.Point(27, 21);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(50, 19);
            this.Width_label.TabIndex = 3;
            this.Width_label.Text = "Width";
            // 
            // Width_Box
            // 
            this.Width_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Width_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Width_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Width_Box.Location = new System.Drawing.Point(83, 21);
            this.Width_Box.Name = "Width_Box";
            this.Width_Box.Size = new System.Drawing.Size(100, 20);
            this.Width_Box.TabIndex = 4;
            // 
            // Height_Box
            // 
            this.Height_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Height_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Height_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Height_Box.Location = new System.Drawing.Point(83, 49);
            this.Height_Box.Name = "Height_Box";
            this.Height_Box.Size = new System.Drawing.Size(100, 20);
            this.Height_Box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(168, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(100, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Data_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(242, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Height_Box);
            this.Controls.Add(this.Width_Box);
            this.Controls.Add(this.Width_label);
            this.Controls.Add(this.Height_label);
            this.Controls.Add(this.Move_Panel);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Data_Modify";
            this.Text = "Data_Modify";
            this.Load += new System.EventHandler(this.Data_Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Move_Panel;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.TextBox Width_Box;
        private System.Windows.Forms.TextBox Height_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}