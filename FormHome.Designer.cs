namespace Proiect_II
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWelcomeUser = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-15, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 733);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dog Hotel Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelWelcomeUser);
            this.panel2.Location = new System.Drawing.Point(223, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 80);
            this.panel2.TabIndex = 1;
            // 
            // labelWelcomeUser
            // 
            this.labelWelcomeUser.AutoSize = true;
            this.labelWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcomeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWelcomeUser.Location = new System.Drawing.Point(122, 30);
            this.labelWelcomeUser.Name = "labelWelcomeUser";
            this.labelWelcomeUser.Size = new System.Drawing.Size(19, 20);
            this.labelWelcomeUser.TabIndex = 3;
            this.labelWelcomeUser.Text = "?";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelDateTime.Location = new System.Drawing.Point(267, 24);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(19, 20);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "?";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelLogOut.Location = new System.Drawing.Point(1157, 24);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(70, 20);
            this.labelLogOut.TabIndex = 3;
            this.labelLogOut.Text = "Log out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proiect_II.Properties.Resources.yellow;
            this.pictureBox5.Location = new System.Drawing.Point(665, 399);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(190, 160);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proiect_II.Properties.Resources.blue;
            this.pictureBox4.Location = new System.Drawing.Point(929, 263);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(190, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proiect_II.Properties.Resources.pink;
            this.pictureBox3.Location = new System.Drawing.Point(403, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proiect_II.Properties.Resources.paw_heart;
            this.pictureBox2.Location = new System.Drawing.Point(48, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_II.Properties.Resources.place_dog_house_building;
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(221)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(481, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(1014, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(126)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(748, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "?";
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(35, 162);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(203, 34);
            this.buttonDashboard.TabIndex = 9;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(35, 194);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(204, 34);
            this.buttonClient.TabIndex = 10;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Location = new System.Drawing.Point(35, 234);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(204, 34);
            this.buttonRoom.TabIndex = 11;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Location = new System.Drawing.Point(35, 274);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(204, 34);
            this.buttonReservation.TabIndex = 12;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(35, 162);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Padding = new System.Windows.Forms.Padding(3);
            this.panelSlide.Size = new System.Drawing.Size(10, 34);
            this.panelSlide.TabIndex = 13;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1280, 697);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Hotel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWelcomeUser;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonClient;
    }
}