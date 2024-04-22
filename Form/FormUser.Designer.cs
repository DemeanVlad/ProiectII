using System.Drawing;
using System.Windows.Forms;

namespace Proiect_II
{
    partial class FormUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelWelcomeUser = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageReservation = new System.Windows.Forms.TabPage();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelObservatii = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.labelTalie = new System.Windows.Forms.Label();
            this.labelRasa = new System.Windows.Forms.Label();
            this.labelPetName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxRasa = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxTalie = new System.Windows.Forms.TextBox();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelReservation = new System.Windows.Forms.Label();
            this.tabPageSearchPet = new System.Windows.Forms.TabPage();
            this.dataGridViewPet = new System.Windows.Forms.DataGridView();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiect_II_DBDataSet1 = new Proiect_II.Proiect_II_DBDataSet1();
            this.labelIdPet = new System.Windows.Forms.Label();
            this.labelIdOwner = new System.Windows.Forms.Label();
            this.textBoxIdPet = new System.Windows.Forms.TextBox();
            this.textBoxIdOwner = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeletePet = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.petTableAdapter = new Proiect_II.Proiect_II_DBDataSet1TableAdapters.PetTableAdapter();
            this.petBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proiect_II_DBDataSet2 = new Proiect_II.Proiect_II_DBDataSet2();
            this.petBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter1 = new Proiect_II.Proiect_II_DBDataSet2TableAdapters.PetTableAdapter();
            this.proiectIIDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talieAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCazareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMeniuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControlReservation.SuspendLayout();
            this.tabPageReservation.SuspendLayout();
            this.tabPageSearchPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet1)).BeginInit();
            this.tabPageUpdateDeletePet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectIIDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonAbout);
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
            this.buttonReservation.Location = new System.Drawing.Point(48, 311);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(304, 52);
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
            this.buttonRoom.Location = new System.Drawing.Point(49, 373);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(304, 52);
            this.buttonRoom.TabIndex = 11;
            this.buttonRoom.Text = "Intrebari frecvente";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(51, 435);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(304, 52);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(51, 249);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(304, 52);
            this.buttonHome.TabIndex = 9;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(105, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dog Hotel";
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
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservation.Controls.Add(this.tabPageReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchPet);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateDeletePet);
            this.tabControlReservation.Location = new System.Drawing.Point(522, 351);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1209, 527);
            this.tabControlReservation.TabIndex = 4;
            this.tabControlReservation.Visible = false;
            // 
            // tabPageReservation
            // 
            this.tabPageReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.tabPageReservation.Controls.Add(this.labelLastName);
            this.tabPageReservation.Controls.Add(this.textBoxLastName);
            this.tabPageReservation.Controls.Add(this.labelObservatii);
            this.tabPageReservation.Controls.Add(this.labelVarsta);
            this.tabPageReservation.Controls.Add(this.labelTalie);
            this.tabPageReservation.Controls.Add(this.labelRasa);
            this.tabPageReservation.Controls.Add(this.labelPetName);
            this.tabPageReservation.Controls.Add(this.labelFirstName);
            this.tabPageReservation.Controls.Add(this.textBoxRasa);
            this.tabPageReservation.Controls.Add(this.textBox5);
            this.tabPageReservation.Controls.Add(this.textBoxTalie);
            this.tabPageReservation.Controls.Add(this.textBoxVarsta);
            this.tabPageReservation.Controls.Add(this.textBoxPetName);
            this.tabPageReservation.Controls.Add(this.textBoxFirstName);
            this.tabPageReservation.Controls.Add(this.buttonSave);
            this.tabPageReservation.Controls.Add(this.labelReservation);
            this.tabPageReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.tabPageReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageReservation.Name = "tabPageReservation";
            this.tabPageReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservation.Size = new System.Drawing.Size(1113, 472);
            this.tabPageReservation.TabIndex = 0;
            this.tabPageReservation.Text = "Add Pet";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLastName.Location = new System.Drawing.Point(463, 58);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(112, 25);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(468, 99);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(246, 26);
            this.textBoxLastName.TabIndex = 18;
            // 
            // labelObservatii
            // 
            this.labelObservatii.AutoSize = true;
            this.labelObservatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObservatii.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelObservatii.Location = new System.Drawing.Point(173, 229);
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
            this.labelVarsta.Location = new System.Drawing.Point(694, 148);
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
            this.labelTalie.Location = new System.Drawing.Point(173, 148);
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
            this.labelRasa.Location = new System.Drawing.Point(391, 148);
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
            this.labelPetName.Location = new System.Drawing.Point(758, 58);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(104, 25);
            this.labelPetName.TabIndex = 13;
            this.labelPetName.Text = "Pet Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFirstName.Location = new System.Drawing.Point(173, 58);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(112, 25);
            this.labelFirstName.TabIndex = 12;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxRasa
            // 
            this.textBoxRasa.Location = new System.Drawing.Point(396, 185);
            this.textBoxRasa.Name = "textBoxRasa";
            this.textBoxRasa.Size = new System.Drawing.Size(246, 26);
            this.textBoxRasa.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 269);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(763, 100);
            this.textBox5.TabIndex = 10;
            // 
            // textBoxTalie
            // 
            this.textBoxTalie.Location = new System.Drawing.Point(178, 185);
            this.textBoxTalie.Name = "textBoxTalie";
            this.textBoxTalie.Size = new System.Drawing.Size(154, 26);
            this.textBoxTalie.TabIndex = 9;
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.Location = new System.Drawing.Point(699, 185);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(154, 26);
            this.textBoxVarsta.TabIndex = 8;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(763, 99);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(246, 26);
            this.textBoxPetName.TabIndex = 7;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(178, 99);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(246, 26);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(498, 396);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 48);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelReservation
            // 
            this.labelReservation.AutoSize = true;
            this.labelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelReservation.Location = new System.Drawing.Point(20, 22);
            this.labelReservation.Name = "labelReservation";
            this.labelReservation.Size = new System.Drawing.Size(214, 26);
            this.labelReservation.TabIndex = 0;
            this.labelReservation.Text = "Make a reservation";
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
            this.tabPageSearchPet.Size = new System.Drawing.Size(1201, 494);
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
            this.dataGridViewPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerIdDataGridViewTextBoxColumn,
            this.animalIdDataGridViewTextBoxColumn,
            this.animalNameDataGridViewTextBoxColumn,
            this.rasaAnimalDataGridViewTextBoxColumn,
            this.talieAnimalDataGridViewTextBoxColumn,
            this.tipCazareDataGridViewTextBoxColumn,
            this.tipMeniuDataGridViewTextBoxColumn,
            this.observatiiDataGridViewTextBoxColumn});
            this.dataGridViewPet.DataSource = this.petBindingSource3;
            this.dataGridViewPet.Location = new System.Drawing.Point(63, 182);
            this.dataGridViewPet.Name = "dataGridViewPet";
            this.dataGridViewPet.ReadOnly = true;
            this.dataGridViewPet.RowHeadersWidth = 62;
            this.dataGridViewPet.RowTemplate.Height = 28;
            this.dataGridViewPet.Size = new System.Drawing.Size(1067, 181);
            this.dataGridViewPet.TabIndex = 28;
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
            // labelIdPet
            // 
            this.labelIdPet.AutoSize = true;
            this.labelIdPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdPet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdPet.Location = new System.Drawing.Point(601, 30);
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
            this.labelIdOwner.Location = new System.Drawing.Point(172, 30);
            this.labelIdOwner.Name = "labelIdOwner";
            this.labelIdOwner.Size = new System.Drawing.Size(100, 25);
            this.labelIdOwner.TabIndex = 26;
            this.labelIdOwner.Text = "ID Owner:";
            // 
            // textBoxIdPet
            // 
            this.textBoxIdPet.Location = new System.Drawing.Point(606, 71);
            this.textBoxIdPet.Name = "textBoxIdPet";
            this.textBoxIdPet.Size = new System.Drawing.Size(246, 26);
            this.textBoxIdPet.TabIndex = 21;
            // 
            // textBoxIdOwner
            // 
            this.textBoxIdOwner.Location = new System.Drawing.Point(177, 71);
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
            this.buttonSearch.Location = new System.Drawing.Point(498, 394);
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
            this.tabPageUpdateDeletePet.Controls.Add(this.buttonDelete);
            this.tabPageUpdateDeletePet.Controls.Add(this.label2);
            this.tabPageUpdateDeletePet.Controls.Add(this.label9);
            this.tabPageUpdateDeletePet.Controls.Add(this.label10);
            this.tabPageUpdateDeletePet.Controls.Add(this.label11);
            this.tabPageUpdateDeletePet.Controls.Add(this.label12);
            this.tabPageUpdateDeletePet.Controls.Add(this.label13);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox8);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox9);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox10);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox11);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox12);
            this.tabPageUpdateDeletePet.Controls.Add(this.textBox13);
            this.tabPageUpdateDeletePet.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateDeletePet.Controls.Add(this.label14);
            this.tabPageUpdateDeletePet.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeletePet.Name = "tabPageUpdateDeletePet";
            this.tabPageUpdateDeletePet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeletePet.Size = new System.Drawing.Size(1113, 472);
            this.tabPageUpdateDeletePet.TabIndex = 2;
            this.tabPageUpdateDeletePet.Text = "Update and Delete Pet";
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
            this.buttonDelete.Location = new System.Drawing.Point(522, 335);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 45);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(170, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Observatii:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(691, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Varsta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(170, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Talie:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(388, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Rasa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(599, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Pet Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(170, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "ID Owner:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(393, 170);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(246, 26);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(175, 254);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(675, 75);
            this.textBox9.TabIndex = 24;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(175, 170);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(154, 26);
            this.textBox10.TabIndex = 23;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(696, 170);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(154, 26);
            this.textBox11.TabIndex = 22;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(604, 84);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(246, 26);
            this.textBox12.TabIndex = 21;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(175, 84);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(246, 26);
            this.textBox13.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(371, 335);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 45);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
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
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // petBindingSource1
            // 
            this.petBindingSource1.DataMember = "Pet";
            this.petBindingSource1.DataSource = this.proiect_II_DBDataSet1;
            // 
            // proiect_II_DBDataSet2
            // 
            this.proiect_II_DBDataSet2.DataSetName = "Proiect_II_DBDataSet2";
            this.proiect_II_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petBindingSource2
            // 
            this.petBindingSource2.DataMember = "Pet";
            this.petBindingSource2.DataSource = this.proiect_II_DBDataSet2;
            // 
            // petTableAdapter1
            // 
            this.petTableAdapter1.ClearBeforeFill = true;
            // 
            // proiectIIDBDataSet2BindingSource
            // 
            this.proiectIIDBDataSet2BindingSource.DataSource = this.proiect_II_DBDataSet2;
            this.proiectIIDBDataSet2BindingSource.Position = 0;
            // 
            // petBindingSource3
            // 
            this.petBindingSource3.DataMember = "Pet";
            this.petBindingSource3.DataSource = this.proiect_II_DBDataSet2;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "owner_Id";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "Owner ID";
            this.ownerIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            this.ownerIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "Pet Name";
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
            // tipCazareDataGridViewTextBoxColumn
            // 
            this.tipCazareDataGridViewTextBoxColumn.DataPropertyName = "tip_Cazare";
            this.tipCazareDataGridViewTextBoxColumn.HeaderText = "Tip Cazare";
            this.tipCazareDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipCazareDataGridViewTextBoxColumn.Name = "tipCazareDataGridViewTextBoxColumn";
            this.tipCazareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipMeniuDataGridViewTextBoxColumn
            // 
            this.tipMeniuDataGridViewTextBoxColumn.DataPropertyName = "tip_Meniu";
            this.tipMeniuDataGridViewTextBoxColumn.HeaderText = "Tip Meniu";
            this.tipMeniuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipMeniuDataGridViewTextBoxColumn.Name = "tipMeniuDataGridViewTextBoxColumn";
            this.tipMeniuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observatiiDataGridViewTextBoxColumn
            // 
            this.observatiiDataGridViewTextBoxColumn.DataPropertyName = "observatii";
            this.observatiiDataGridViewTextBoxColumn.HeaderText = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.observatiiDataGridViewTextBoxColumn.Name = "observatiiDataGridViewTextBoxColumn";
            this.observatiiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1920, 1072);
            this.Controls.Add(this.tabControlReservation);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Hotel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageReservation.ResumeLayout(false);
            this.tabPageReservation.PerformLayout();
            this.tabPageSearchPet.ResumeLayout(false);
            this.tabPageSearchPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet1)).EndInit();
            this.tabPageUpdateDeletePet.ResumeLayout(false);
            this.tabPageUpdateDeletePet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiect_II_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectIIDBDataSet2BindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonAbout;
        private TabControl tabControlReservation;
        private TabPage tabPageReservation;
        private Label labelObservatii;
        private Label labelVarsta;
        private Label labelTalie;
        private Label labelRasa;
        private Label labelPetName;
        private Label labelFirstName;
        private TextBox textBoxRasa;
        private TextBox textBox5;
        private TextBox textBoxTalie;
        private TextBox textBoxVarsta;
        private TextBox textBoxPetName;
        private TextBox textBoxFirstName;
        private Button buttonSave;
        private Label labelReservation;
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
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Button buttonUpdate;
        private Label label14;
        private Proiect_II_DBDataSet1 proiect_II_DBDataSet1;
        private BindingSource petBindingSource;
        private Proiect_II_DBDataSet1TableAdapters.PetTableAdapter petTableAdapter;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private BindingSource petBindingSource1;
        private Proiect_II_DBDataSet2 proiect_II_DBDataSet2;
        private BindingSource petBindingSource2;
        private Proiect_II_DBDataSet2TableAdapters.PetTableAdapter petTableAdapter1;
        private BindingSource petBindingSource3;
        private BindingSource proiectIIDBDataSet2BindingSource;
        private DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rasaAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn talieAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipCazareDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipMeniuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observatiiDataGridViewTextBoxColumn;
    }
}