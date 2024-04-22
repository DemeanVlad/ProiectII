using System.Drawing;
using System.Windows.Forms;

namespace Proiect_II
{
    partial class FormManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonOwner = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelWelcomeUser = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.tabControlPet = new System.Windows.Forms.TabControl();
            this.tabPageAddPet = new System.Windows.Forms.TabPage();
            this.labelObservatii = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.labelTalie = new System.Windows.Forms.Label();
            this.labelRasa = new System.Windows.Forms.Label();
            this.labelPetName = new System.Windows.Forms.Label();
            this.labelOwnerId = new System.Windows.Forms.Label();
            this.textBoxRasa = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxTalie = new System.Windows.Forms.TextBox();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.textBoxOwnerId = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelAddClient = new System.Windows.Forms.Label();
            this.tabPageSearchPet = new System.Windows.Forms.TabPage();
            this.dataGridViewPet = new System.Windows.Forms.DataGridView();
            this.owner_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talieAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_Cazare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_Meniu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proiect_II_DBDataSet2 = new Proiect_II.Proiect_II_DBDataSet2();
            this.labelIdPet = new System.Windows.Forms.Label();
            this.labelIdOwner = new System.Windows.Forms.Label();
            this.textBoxIdPet = new System.Windows.Forms.TextBox();
            this.textBoxIdOwner = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeletePet = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiect_II_DBDataSet1 = new Proiect_II.Proiect_II_DBDataSet1();
            this.petTableAdapter = new Proiect_II.Proiect_II_DBDataSet1TableAdapters.PetTableAdapter();
            this.petTableAdapter1 = new Proiect_II.Proiect_II_DBDataSet2TableAdapters.PetTableAdapter();
            this.petBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proiect_II_DBDataSet3 = new Proiect_II.Proiect_II_DBDataSet3();
            this.petBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter2 = new Proiect_II.Proiect_II_DBDataSet3TableAdapters.PetTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControlPet.SuspendLayout();
            this.tabPageAddPet.SuspendLayout();
            this.tabPageSearchPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet2)).BeginInit();
            this.tabPageUpdateDeletePet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonPet);
            this.panel1.Controls.Add(this.buttonOwner);
            this.panel1.Location = new System.Drawing.Point(-22, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 1128);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(52, 249);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSlide.Size = new System.Drawing.Size(15, 52);
            this.panelSlide.TabIndex = 13;
            // 
            // buttonReservation
            // 
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Location = new System.Drawing.Point(52, 497);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(306, 52);
            this.buttonReservation.TabIndex = 12;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Location = new System.Drawing.Point(50, 435);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(306, 52);
            this.buttonRoom.TabIndex = 11;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(51, 249);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(304, 52);
            this.buttonDashboard.TabIndex = 9;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dog Hotel Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_II.Properties.Resources.place_dog_house_building;
            this.pictureBox1.Location = new System.Drawing.Point(122, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPet
            // 
            this.buttonPet.FlatAppearance.BorderSize = 0;
            this.buttonPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPet.ForeColor = System.Drawing.Color.White;
            this.buttonPet.Location = new System.Drawing.Point(50, 311);
            this.buttonPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(306, 52);
            this.buttonPet.TabIndex = 10;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // buttonOwner
            // 
            this.buttonOwner.FlatAppearance.BorderSize = 0;
            this.buttonOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOwner.ForeColor = System.Drawing.Color.White;
            this.buttonOwner.Location = new System.Drawing.Point(50, 373);
            this.buttonOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOwner.Name = "buttonOwner";
            this.buttonOwner.Size = new System.Drawing.Size(306, 52);
            this.buttonOwner.TabIndex = 12;
            this.buttonOwner.Text = "Owner";
            this.buttonOwner.UseVisualStyleBackColor = true;
            this.buttonOwner.Click += new System.EventHandler(this.buttonOwner_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelWelcomeUser);
            this.panel2.Location = new System.Drawing.Point(334, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1808, 123);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proiect_II.Properties.Resources.paw_heart;
            this.pictureBox2.Location = new System.Drawing.Point(72, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // labelWelcomeUser
            // 
            this.labelWelcomeUser.AutoSize = true;
            this.labelWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcomeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWelcomeUser.Location = new System.Drawing.Point(183, 46);
            this.labelWelcomeUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcomeUser.Name = "labelWelcomeUser";
            this.labelWelcomeUser.Size = new System.Drawing.Size(26, 29);
            this.labelWelcomeUser.TabIndex = 3;
            this.labelWelcomeUser.Text = "?";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelDateTime.Location = new System.Drawing.Point(400, 37);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(26, 29);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "?";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelLogOut.Location = new System.Drawing.Point(1736, 37);
            this.labelLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(100, 29);
            this.labelLogOut.TabIndex = 3;
            this.labelLogOut.Text = "Log out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // tabControlPet
            // 
            this.tabControlPet.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlPet.Controls.Add(this.tabPageAddPet);
            this.tabControlPet.Controls.Add(this.tabPageSearchPet);
            this.tabControlPet.Controls.Add(this.tabPageUpdateDeletePet);
            this.tabControlPet.Location = new System.Drawing.Point(462, 373);
            this.tabControlPet.Name = "tabControlPet";
            this.tabControlPet.SelectedIndex = 0;
            this.tabControlPet.Size = new System.Drawing.Size(1331, 505);
            this.tabControlPet.TabIndex = 4;
            this.tabControlPet.Visible = false;
            // 
            // tabPageAddPet
            // 
            this.tabPageAddPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.tabPageAddPet.Controls.Add(this.labelObservatii);
            this.tabPageAddPet.Controls.Add(this.labelVarsta);
            this.tabPageAddPet.Controls.Add(this.labelTalie);
            this.tabPageAddPet.Controls.Add(this.labelRasa);
            this.tabPageAddPet.Controls.Add(this.labelPetName);
            this.tabPageAddPet.Controls.Add(this.labelOwnerId);
            this.tabPageAddPet.Controls.Add(this.textBoxRasa);
            this.tabPageAddPet.Controls.Add(this.textBox5);
            this.tabPageAddPet.Controls.Add(this.textBoxTalie);
            this.tabPageAddPet.Controls.Add(this.textBoxVarsta);
            this.tabPageAddPet.Controls.Add(this.textBoxPetName);
            this.tabPageAddPet.Controls.Add(this.textBoxOwnerId);
            this.tabPageAddPet.Controls.Add(this.buttonLogin);
            this.tabPageAddPet.Controls.Add(this.labelAddClient);
            this.tabPageAddPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.tabPageAddPet.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddPet.Name = "tabPageAddPet";
            this.tabPageAddPet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddPet.Size = new System.Drawing.Size(1323, 472);
            this.tabPageAddPet.TabIndex = 0;
            this.tabPageAddPet.Text = "Add Pet";
            // 
            // labelObservatii
            // 
            this.labelObservatii.AutoSize = true;
            this.labelObservatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObservatii.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelObservatii.Location = new System.Drawing.Point(233, 195);
            this.labelObservatii.Name = "labelObservatii";
            this.labelObservatii.Size = new System.Drawing.Size(106, 25);
            this.labelObservatii.TabIndex = 17;
            this.labelObservatii.Text = "Observatii:";
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVarsta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVarsta.Location = new System.Drawing.Point(754, 114);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(75, 25);
            this.labelVarsta.TabIndex = 16;
            this.labelVarsta.Text = "Varsta:";
            // 
            // labelTalie
            // 
            this.labelTalie.AutoSize = true;
            this.labelTalie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTalie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTalie.Location = new System.Drawing.Point(233, 114);
            this.labelTalie.Name = "labelTalie";
            this.labelTalie.Size = new System.Drawing.Size(61, 25);
            this.labelTalie.TabIndex = 15;
            this.labelTalie.Text = "Talie:";
            // 
            // labelRasa
            // 
            this.labelRasa.AutoSize = true;
            this.labelRasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRasa.Location = new System.Drawing.Point(451, 114);
            this.labelRasa.Name = "labelRasa";
            this.labelRasa.Size = new System.Drawing.Size(63, 25);
            this.labelRasa.TabIndex = 14;
            this.labelRasa.Text = "Rasa:";
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPetName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPetName.Location = new System.Drawing.Point(662, 24);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(104, 25);
            this.labelPetName.TabIndex = 13;
            this.labelPetName.Text = "Pet Name:";
            // 
            // labelOwnerId
            // 
            this.labelOwnerId.AutoSize = true;
            this.labelOwnerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOwnerId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOwnerId.Location = new System.Drawing.Point(233, 24);
            this.labelOwnerId.Name = "labelOwnerId";
            this.labelOwnerId.Size = new System.Drawing.Size(100, 25);
            this.labelOwnerId.TabIndex = 12;
            this.labelOwnerId.Text = "ID Owner:";
            // 
            // textBoxRasa
            // 
            this.textBoxRasa.Location = new System.Drawing.Point(456, 151);
            this.textBoxRasa.Name = "textBoxRasa";
            this.textBoxRasa.Size = new System.Drawing.Size(246, 26);
            this.textBoxRasa.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(238, 237);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(833, 138);
            this.textBox5.TabIndex = 10;
            // 
            // textBoxTalie
            // 
            this.textBoxTalie.Location = new System.Drawing.Point(238, 151);
            this.textBoxTalie.Name = "textBoxTalie";
            this.textBoxTalie.Size = new System.Drawing.Size(154, 26);
            this.textBoxTalie.TabIndex = 9;
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.Location = new System.Drawing.Point(759, 151);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(154, 26);
            this.textBoxVarsta.TabIndex = 8;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(667, 65);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(246, 26);
            this.textBoxPetName.TabIndex = 7;
            // 
            // textBoxOwnerId
            // 
            this.textBoxOwnerId.Location = new System.Drawing.Point(238, 65);
            this.textBoxOwnerId.Name = "textBoxOwnerId";
            this.textBoxOwnerId.Size = new System.Drawing.Size(246, 26);
            this.textBoxOwnerId.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(612, 399);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 45);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Add";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // labelAddClient
            // 
            this.labelAddClient.AutoSize = true;
            this.labelAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelAddClient.Location = new System.Drawing.Point(23, 23);
            this.labelAddClient.Name = "labelAddClient";
            this.labelAddClient.Size = new System.Drawing.Size(97, 26);
            this.labelAddClient.TabIndex = 0;
            this.labelAddClient.Text = "Add Pet";
            // 
            // tabPageSearchPet
            // 
            this.tabPageSearchPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.tabPageSearchPet.Controls.Add(this.dataGridViewPet);
            this.tabPageSearchPet.Controls.Add(this.labelIdPet);
            this.tabPageSearchPet.Controls.Add(this.labelIdOwner);
            this.tabPageSearchPet.Controls.Add(this.textBoxIdPet);
            this.tabPageSearchPet.Controls.Add(this.textBoxIdOwner);
            this.tabPageSearchPet.Controls.Add(this.buttonSearch);
            this.tabPageSearchPet.Controls.Add(this.label8);
            this.tabPageSearchPet.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchPet.Name = "tabPageSearchPet";
            this.tabPageSearchPet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchPet.Size = new System.Drawing.Size(1323, 472);
            this.tabPageSearchPet.TabIndex = 1;
            this.tabPageSearchPet.Text = "Search Pet";
            // 
            // dataGridViewPet
            // 
            this.dataGridViewPet.AllowUserToAddRows = false;
            this.dataGridViewPet.AllowUserToDeleteRows = false;
            this.dataGridViewPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPet.AutoGenerateColumns = false;
            this.dataGridViewPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owner_Id,
            this.animalIdDataGridViewTextBoxColumn,
            this.animalNameDataGridViewTextBoxColumn,
            this.rasaAnimalDataGridViewTextBoxColumn,
            this.talieAnimalDataGridViewTextBoxColumn,
            this.tip_Cazare,
            this.tip_Meniu,
            this.observatiiDataGridViewTextBoxColumn});
            this.dataGridViewPet.DataSource = this.petBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPet.Location = new System.Drawing.Point(82, 172);
            this.dataGridViewPet.Name = "dataGridViewPet";
            this.dataGridViewPet.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPet.RowHeadersWidth = 62;
            this.dataGridViewPet.RowTemplate.Height = 28;
            this.dataGridViewPet.Size = new System.Drawing.Size(1155, 181);
            this.dataGridViewPet.TabIndex = 28;
            // 
            // owner_Id
            // 
            this.owner_Id.DataPropertyName = "owner_Id";
            this.owner_Id.HeaderText = "Owner ID";
            this.owner_Id.MinimumWidth = 8;
            this.owner_Id.Name = "owner_Id";
            this.owner_Id.ReadOnly = true;
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "animal_Id";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "Pet ID";
            this.animalIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalNameDataGridViewTextBoxColumn
            // 
            this.animalNameDataGridViewTextBoxColumn.DataPropertyName = "animal_Name";
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.animalNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.animalNameDataGridViewTextBoxColumn.Name = "animalNameDataGridViewTextBoxColumn";
            this.animalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rasaAnimalDataGridViewTextBoxColumn
            // 
            this.rasaAnimalDataGridViewTextBoxColumn.DataPropertyName = "rasa_Animal";
            this.rasaAnimalDataGridViewTextBoxColumn.HeaderText = "Rasa";
            this.rasaAnimalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rasaAnimalDataGridViewTextBoxColumn.Name = "rasaAnimalDataGridViewTextBoxColumn";
            this.rasaAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // talieAnimalDataGridViewTextBoxColumn
            // 
            this.talieAnimalDataGridViewTextBoxColumn.DataPropertyName = "talie_Animal";
            this.talieAnimalDataGridViewTextBoxColumn.HeaderText = "Talie";
            this.talieAnimalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.talieAnimalDataGridViewTextBoxColumn.Name = "talieAnimalDataGridViewTextBoxColumn";
            this.talieAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tip_Cazare
            // 
            this.tip_Cazare.DataPropertyName = "tip_Cazare";
            this.tip_Cazare.HeaderText = "Tip Cazare";
            this.tip_Cazare.MinimumWidth = 8;
            this.tip_Cazare.Name = "tip_Cazare";
            this.tip_Cazare.ReadOnly = true;
            // 
            // tip_Meniu
            // 
            this.tip_Meniu.DataPropertyName = "tip_Meniu";
            this.tip_Meniu.HeaderText = "Tip Meniu";
            this.tip_Meniu.MinimumWidth = 8;
            this.tip_Meniu.Name = "tip_Meniu";
            this.tip_Meniu.ReadOnly = true;
            // 
            // observatiiDataGridViewTextBoxColumn
            // 
            this.observatiiDataGridViewTextBoxColumn.DataPropertyName = "observatii";
            this.observatiiDataGridViewTextBoxColumn.HeaderText = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.observatiiDataGridViewTextBoxColumn.Name = "observatiiDataGridViewTextBoxColumn";
            this.observatiiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petBindingSource1
            // 
            this.petBindingSource1.DataMember = "Pet";
            this.petBindingSource1.DataSource = this.proiect_II_DBDataSet2;
            // 
            // proiect_II_DBDataSet2
            // 
            this.proiect_II_DBDataSet2.DataSetName = "Proiect_II_DBDataSet2";
            this.proiect_II_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelIdPet
            // 
            this.labelIdPet.AutoSize = true;
            this.labelIdPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdPet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdPet.Location = new System.Drawing.Point(738, 54);
            this.labelIdPet.Name = "labelIdPet";
            this.labelIdPet.Size = new System.Drawing.Size(71, 25);
            this.labelIdPet.TabIndex = 27;
            this.labelIdPet.Text = "ID Pet:";
            // 
            // labelIdOwner
            // 
            this.labelIdOwner.AutoSize = true;
            this.labelIdOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdOwner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdOwner.Location = new System.Drawing.Point(309, 54);
            this.labelIdOwner.Name = "labelIdOwner";
            this.labelIdOwner.Size = new System.Drawing.Size(100, 25);
            this.labelIdOwner.TabIndex = 26;
            this.labelIdOwner.Text = "ID Owner:";
            // 
            // textBoxIdPet
            // 
            this.textBoxIdPet.Location = new System.Drawing.Point(743, 95);
            this.textBoxIdPet.Name = "textBoxIdPet";
            this.textBoxIdPet.Size = new System.Drawing.Size(246, 26);
            this.textBoxIdPet.TabIndex = 21;
            // 
            // textBoxIdOwner
            // 
            this.textBoxIdOwner.Location = new System.Drawing.Point(314, 95);
            this.textBoxIdOwner.Name = "textBoxIdOwner";
            this.textBoxIdOwner.Size = new System.Drawing.Size(246, 26);
            this.textBoxIdOwner.TabIndex = 20;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(600, 395);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 45);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search Pet";
            // 
            // tabPageUpdateDeletePet
            // 
            this.tabPageUpdateDeletePet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.tabPageUpdateDeletePet.Controls.Add(this.button1);
            this.tabPageUpdateDeletePet.Controls.Add(this.label2);
            this.tabPageUpdateDeletePet.Controls.Add(this.label3);
            this.tabPageUpdateDeletePet.Controls.Add(this.label4);
            this.tabPageUpdateDeletePet.Controls.Add(this.label5);
            this.tabPageUpdateDeletePet.Controls.Add(this.label6);
            this.tabPageUpdateDeletePet.Controls.Add(this.label7);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox1);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox2);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox3);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox4);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox6);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox7);
            this.tabPageUpdateDeletePet.Controls.Add(this.buttonDelete);
            this.tabPageUpdateDeletePet.Controls.Add(this.label14);
            this.tabPageUpdateDeletePet.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeletePet.Name = "tabPageUpdateDeletePet";
            this.tabPageUpdateDeletePet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeletePet.Size = new System.Drawing.Size(1323, 472);
            this.tabPageUpdateDeletePet.TabIndex = 2;
            this.tabPageUpdateDeletePet.Text = "Update and Delete Pet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(509, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 45;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(238, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Observatii:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(759, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Varsta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(238, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Talie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(456, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Rasa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(667, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Pet Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(238, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "ID Owner:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 256);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(833, 138);
            this.textBox2.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 26);
            this.textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(764, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 26);
            this.textBox4.TabIndex = 35;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(672, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(246, 26);
            this.textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(243, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(246, 26);
            this.textBox7.TabIndex = 33;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(692, 408);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 45);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(253, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "Update and Delete Pet";
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.proiect_II_DBDataSet1;
            // 
            // proiect_II_DBDataSet1
            // 
            this.proiect_II_DBDataSet1.DataSetName = "Proiect_II_DBDataSet1";
            this.proiect_II_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // petTableAdapter1
            // 
            this.petTableAdapter1.ClearBeforeFill = true;
            // 
            // petBindingSource2
            // 
            this.petBindingSource2.DataMember = "Pet";
            this.petBindingSource2.DataSource = this.proiect_II_DBDataSet2;
            // 
            // proiect_II_DBDataSet3
            // 
            this.proiect_II_DBDataSet3.DataSetName = "Proiect_II_DBDataSet3";
            this.proiect_II_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petBindingSource3
            // 
            this.petBindingSource3.DataMember = "Pet";
            this.petBindingSource3.DataSource = this.proiect_II_DBDataSet3;
            // 
            // petTableAdapter2
            // 
            this.petTableAdapter2.ClearBeforeFill = true;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1920, 1072);
            this.Controls.Add(this.tabControlPet);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Hotel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControlPet.ResumeLayout(false);
            this.tabPageAddPet.ResumeLayout(false);
            this.tabPageAddPet.PerformLayout();
            this.tabPageSearchPet.ResumeLayout(false);
            this.tabPageSearchPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet2)).EndInit();
            this.tabPageUpdateDeletePet.ResumeLayout(false);
            this.tabPageUpdateDeletePet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource3)).EndInit();
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
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonPet;
        private Button buttonOwner;
        private TabControl tabControlPet;
        private TabPage tabPageAddPet;
        private Label labelObservatii;
        private Label labelVarsta;
        private Label labelTalie;
        private Label labelRasa;
        private Label labelPetName;
        private Label labelOwnerId;
        private TextBox textBoxRasa;
        private TextBox textBox5;
        private TextBox textBoxTalie;
        private TextBox textBoxVarsta;
        private TextBox textBoxPetName;
        private TextBox textBoxOwnerId;
        private Button buttonLogin;
        private Label labelAddClient;
        private TabPage tabPageSearchPet;
        private DataGridView dataGridViewPet;
        private Label labelIdPet;
        private Label labelIdOwner;
        private TextBox textBoxIdPet;
        private TextBox textBoxIdOwner;
        private Button buttonSearch;
        private Label label8;
        private TabPage tabPageUpdateDeletePet;
        private Button buttonDelete;
        private Label label14;
        private Proiect_II_DBDataSet1 proiect_II_DBDataSet1;
        private BindingSource petBindingSource;
        private Proiect_II_DBDataSet1TableAdapters.PetTableAdapter petTableAdapter;
        private Proiect_II_DBDataSet2 proiect_II_DBDataSet2;
        private BindingSource petBindingSource1;
        private Proiect_II_DBDataSet2TableAdapters.PetTableAdapter petTableAdapter1;
        private DataGridViewTextBoxColumn owner_Id;
        private DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rasaAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn talieAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tip_Cazare;
        private DataGridViewTextBoxColumn tip_Meniu;
        private DataGridViewTextBoxColumn observatiiDataGridViewTextBoxColumn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private BindingSource petBindingSource2;
        private Proiect_II_DBDataSet3 proiect_II_DBDataSet3;
        private BindingSource petBindingSource3;
        private Proiect_II_DBDataSet3TableAdapters.PetTableAdapter petTableAdapter2;
    }
}