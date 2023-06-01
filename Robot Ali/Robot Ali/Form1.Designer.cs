namespace Robot_Ali
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_img = new System.Windows.Forms.Label();
            this.imageList_icon = new System.Windows.Forms.ImageList(this.components);
            this.lbl_cm = new System.Windows.Forms.Label();
            this.lbl_valueKhoancach = new System.Windows.Forms.Label();
            this.lbl_KhoangCach = new System.Windows.Forms.Label();
            this.timer_loadvalue = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.lbl_img);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 154);
            this.pnl_top.TabIndex = 4;
            this.pnl_top.Tag = "ădad";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Elephant", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(209, 70);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(274, 62);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Robot Ali";
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img.ImageIndex = 0;
            this.lbl_img.ImageList = this.imageList_icon;
            this.lbl_img.Location = new System.Drawing.Point(41, 10);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(153, 135);
            this.lbl_img.TabIndex = 1;
            this.lbl_img.Text = "   ";
            // 
            // imageList_icon
            // 
            this.imageList_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_icon.ImageStream")));
            this.imageList_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_icon.Images.SetKeyName(0, "88068_robot_icon.png");
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cm.Location = new System.Drawing.Point(302, 215);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(50, 31);
            this.lbl_cm.TabIndex = 7;
            this.lbl_cm.Text = "cm";
            this.lbl_cm.Click += new System.EventHandler(this.lbl_cm_Click);
            // 
            // lbl_valueKhoancach
            // 
            this.lbl_valueKhoancach.AutoSize = true;
            this.lbl_valueKhoancach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valueKhoancach.Location = new System.Drawing.Point(252, 215);
            this.lbl_valueKhoancach.Name = "lbl_valueKhoancach";
            this.lbl_valueKhoancach.Size = new System.Drawing.Size(44, 31);
            this.lbl_valueKhoancach.TabIndex = 6;
            this.lbl_valueKhoancach.Text = "30";
            this.lbl_valueKhoancach.Click += new System.EventHandler(this.lbl_value_Click);
            // 
            // lbl_KhoangCach
            // 
            this.lbl_KhoangCach.AutoSize = true;
            this.lbl_KhoangCach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhoangCach.Location = new System.Drawing.Point(46, 215);
            this.lbl_KhoangCach.Name = "lbl_KhoangCach";
            this.lbl_KhoangCach.Size = new System.Drawing.Size(200, 31);
            this.lbl_KhoangCach.TabIndex = 5;
            this.lbl_KhoangCach.Text = "Khoảng cách :";
            // 
            // timer_loadvalue
            // 
            this.timer_loadvalue.Interval = 1000;
            this.timer_loadvalue.Tick += new System.EventHandler(this.timer_loadvalue_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.lbl_cm);
            this.Controls.Add(this.lbl_valueKhoancach);
            this.Controls.Add(this.lbl_KhoangCach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_img;
        private System.Windows.Forms.ImageList imageList_icon;
 
        private System.Windows.Forms.Label lbl_cm;
        private System.Windows.Forms.Label lbl_valueKhoancach;
        private System.Windows.Forms.Label lbl_KhoangCach;
        private System.Windows.Forms.Timer timer_loadvalue;
    }
}

