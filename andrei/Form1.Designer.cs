namespace andrei
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture = new System.Windows.Forms.PictureBox();
            this.Rotate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Sx = new System.Windows.Forms.TextBox();
            this.Sy = new System.Windows.Forms.TextBox();
            this.Sz = new System.Windows.Forms.TextBox();
            this.alpha = new System.Windows.Forms.TextBox();
            this.gama = new System.Windows.Forms.TextBox();
            this.beta = new System.Windows.Forms.TextBox();
            this.Dx = new System.Windows.Forms.TextBox();
            this.Dy = new System.Windows.Forms.TextBox();
            this.Dz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Radius2 = new System.Windows.Forms.TextBox();
            this.Approximation = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Radius1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button10 = new System.Windows.Forms.Button();
            this.Fi = new System.Windows.Forms.TextBox();
            this.Psi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.TextBox();
            this.Lol = new System.Windows.Forms.Label();
            this.polygon = new System.Windows.Forms.RadioButton();
            this.Horizontal = new System.Windows.Forms.RadioButton();
            this.Profile = new System.Windows.Forms.RadioButton();
            this.Perspective = new System.Windows.Forms.RadioButton();
            this.Axonometric = new System.Windows.Forms.RadioButton();
            this.Oblique = new System.Windows.Forms.RadioButton();
            this.l = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.tet = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.ro = new System.Windows.Forms.Label();
            this.roT = new System.Windows.Forms.TextBox();
            this.fiT = new System.Windows.Forms.TextBox();
            this.Dont = new System.Windows.Forms.RadioButton();
            this.tetaT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Auto = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.Z = new System.Windows.Forms.TextBox();
            this.Ia = new System.Windows.Forms.TextBox();
            this.kd = new System.Windows.Forms.TextBox();
            this.Il = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(-2, 1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(716, 589);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // Rotate
            // 
            this.Rotate.BackColor = System.Drawing.SystemColors.ControlText;
            this.Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rotate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rotate.ForeColor = System.Drawing.SystemColors.Control;
            this.Rotate.Location = new System.Drawing.Point(3, 159);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(60, 32);
            this.Rotate.TabIndex = 1;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = false;
            this.Rotate.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(3, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Scale";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(3, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Move";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Sx
            // 
            this.Sx.BackColor = System.Drawing.Color.Silver;
            this.Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sx.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sx.ForeColor = System.Drawing.Color.Black;
            this.Sx.Location = new System.Drawing.Point(65, 218);
            this.Sx.Name = "Sx";
            this.Sx.Size = new System.Drawing.Size(41, 21);
            this.Sx.TabIndex = 4;
            this.Sx.Text = "2";
            // 
            // Sy
            // 
            this.Sy.BackColor = System.Drawing.Color.Silver;
            this.Sy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sy.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sy.ForeColor = System.Drawing.Color.Black;
            this.Sy.Location = new System.Drawing.Point(106, 218);
            this.Sy.Name = "Sy";
            this.Sy.Size = new System.Drawing.Size(41, 21);
            this.Sy.TabIndex = 5;
            this.Sy.Text = "2";
            // 
            // Sz
            // 
            this.Sz.BackColor = System.Drawing.Color.Silver;
            this.Sz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sz.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sz.ForeColor = System.Drawing.Color.Black;
            this.Sz.Location = new System.Drawing.Point(145, 218);
            this.Sz.Name = "Sz";
            this.Sz.Size = new System.Drawing.Size(38, 21);
            this.Sz.TabIndex = 6;
            this.Sz.Text = "2";
            // 
            // alpha
            // 
            this.alpha.BackColor = System.Drawing.Color.Silver;
            this.alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alpha.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alpha.ForeColor = System.Drawing.Color.Black;
            this.alpha.Location = new System.Drawing.Point(65, 171);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(41, 21);
            this.alpha.TabIndex = 7;
            this.alpha.Text = "10";
            // 
            // gama
            // 
            this.gama.BackColor = System.Drawing.Color.Silver;
            this.gama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gama.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gama.ForeColor = System.Drawing.Color.Black;
            this.gama.Location = new System.Drawing.Point(145, 171);
            this.gama.Name = "gama";
            this.gama.Size = new System.Drawing.Size(38, 21);
            this.gama.TabIndex = 8;
            this.gama.Text = "10";
            // 
            // beta
            // 
            this.beta.BackColor = System.Drawing.Color.Silver;
            this.beta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beta.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beta.ForeColor = System.Drawing.Color.Black;
            this.beta.Location = new System.Drawing.Point(106, 171);
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(39, 21);
            this.beta.TabIndex = 9;
            this.beta.Text = "10";
            // 
            // Dx
            // 
            this.Dx.BackColor = System.Drawing.Color.Silver;
            this.Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dx.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dx.ForeColor = System.Drawing.Color.Black;
            this.Dx.Location = new System.Drawing.Point(65, 263);
            this.Dx.Name = "Dx";
            this.Dx.Size = new System.Drawing.Size(41, 21);
            this.Dx.TabIndex = 10;
            this.Dx.Text = "10";
            // 
            // Dy
            // 
            this.Dy.BackColor = System.Drawing.Color.Silver;
            this.Dy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dy.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dy.ForeColor = System.Drawing.Color.Black;
            this.Dy.Location = new System.Drawing.Point(106, 263);
            this.Dy.Name = "Dy";
            this.Dy.Size = new System.Drawing.Size(40, 21);
            this.Dy.TabIndex = 11;
            this.Dy.Text = "10";
            // 
            // Dz
            // 
            this.Dz.BackColor = System.Drawing.Color.Silver;
            this.Dz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dz.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dz.ForeColor = System.Drawing.Color.Black;
            this.Dz.Location = new System.Drawing.Point(145, 263);
            this.Dz.Name = "Dz";
            this.Dz.Size = new System.Drawing.Size(38, 21);
            this.Dz.TabIndex = 12;
            this.Dz.Text = "10";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Radius2
            // 
            this.Radius2.BackColor = System.Drawing.Color.Silver;
            this.Radius2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Radius2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radius2.ForeColor = System.Drawing.Color.Black;
            this.Radius2.Location = new System.Drawing.Point(125, 29);
            this.Radius2.Name = "Radius2";
            this.Radius2.Size = new System.Drawing.Size(50, 23);
            this.Radius2.TabIndex = 14;
            this.Radius2.Text = "80";
            // 
            // Approximation
            // 
            this.Approximation.BackColor = System.Drawing.Color.Silver;
            this.Approximation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Approximation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Approximation.ForeColor = System.Drawing.Color.Black;
            this.Approximation.Location = new System.Drawing.Point(125, 74);
            this.Approximation.Name = "Approximation";
            this.Approximation.Size = new System.Drawing.Size(50, 23);
            this.Approximation.TabIndex = 15;
            this.Approximation.Text = "16";
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.Color.Silver;
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Height.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.ForeColor = System.Drawing.Color.Black;
            this.Height.Location = new System.Drawing.Point(125, 51);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(50, 23);
            this.Height.TabIndex = 16;
            this.Height.Text = "250";
            // 
            // Radius1
            // 
            this.Radius1.BackColor = System.Drawing.Color.Silver;
            this.Radius1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Radius1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radius1.ForeColor = System.Drawing.Color.Black;
            this.Radius1.Location = new System.Drawing.Point(125, 6);
            this.Radius1.Name = "Radius1";
            this.Radius1.Size = new System.Drawing.Size(50, 23);
            this.Radius1.TabIndex = 17;
            this.Radius1.Text = "150";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "BigRadius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "SmallRadius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Approximation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(64, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "alpha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(107, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "beta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(143, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "gama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(69, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sx:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(112, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Sy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(152, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Sz:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(71, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Dx:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(112, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Dy:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(150, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Dz:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 23);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lines";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 23);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.Text = "Points";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.PowderBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(186, 38);
            this.button10.TabIndex = 42;
            this.button10.Text = "Redraw";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button_Click);
            // 
            // Fi
            // 
            this.Fi.BackColor = System.Drawing.Color.Silver;
            this.Fi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fi.ForeColor = System.Drawing.Color.Black;
            this.Fi.Location = new System.Drawing.Point(41, 120);
            this.Fi.Name = "Fi";
            this.Fi.Size = new System.Drawing.Size(38, 23);
            this.Fi.TabIndex = 43;
            this.Fi.Text = "10";
            // 
            // Psi
            // 
            this.Psi.BackColor = System.Drawing.Color.Silver;
            this.Psi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Psi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Psi.ForeColor = System.Drawing.Color.Black;
            this.Psi.Location = new System.Drawing.Point(3, 120);
            this.Psi.Name = "Psi";
            this.Psi.Size = new System.Drawing.Size(38, 23);
            this.Psi.TabIndex = 44;
            this.Psi.Text = "10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(14, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "ψ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(45, 100);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(22, 17);
            this.label17.TabIndex = 46;
            this.label17.Text = "φ ";
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.Silver;
            this.d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.d.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d.ForeColor = System.Drawing.Color.Black;
            this.d.Location = new System.Drawing.Point(3, 252);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(38, 23);
            this.d.TabIndex = 47;
            this.d.Text = "300";
            // 
            // Lol
            // 
            this.Lol.AutoSize = true;
            this.Lol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lol.Location = new System.Drawing.Point(15, 232);
            this.Lol.Name = "Lol";
            this.Lol.Size = new System.Drawing.Size(16, 17);
            this.Lol.TabIndex = 48;
            this.Lol.Text = "d";
            // 
            // polygon
            // 
            this.polygon.AutoSize = true;
            this.polygon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polygon.ForeColor = System.Drawing.Color.Black;
            this.polygon.Location = new System.Drawing.Point(3, 49);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(82, 23);
            this.polygon.TabIndex = 50;
            this.polygon.TabStop = true;
            this.polygon.Text = "Polygon";
            this.polygon.UseVisualStyleBackColor = true;
            this.polygon.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // Horizontal
            // 
            this.Horizontal.AutoSize = true;
            this.Horizontal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Horizontal.ForeColor = System.Drawing.Color.Black;
            this.Horizontal.Location = new System.Drawing.Point(3, 30);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(91, 21);
            this.Horizontal.TabIndex = 51;
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.UseVisualStyleBackColor = true;
            this.Horizontal.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profile.ForeColor = System.Drawing.Color.Black;
            this.Profile.Location = new System.Drawing.Point(3, 57);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(67, 21);
            this.Profile.TabIndex = 52;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // Perspective
            // 
            this.Perspective.AutoSize = true;
            this.Perspective.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Perspective.ForeColor = System.Drawing.Color.Black;
            this.Perspective.Location = new System.Drawing.Point(2, 214);
            this.Perspective.Name = "Perspective";
            this.Perspective.Size = new System.Drawing.Size(96, 21);
            this.Perspective.TabIndex = 54;
            this.Perspective.Text = "Perspective";
            this.Perspective.UseVisualStyleBackColor = true;
            this.Perspective.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // Axonometric
            // 
            this.Axonometric.AutoSize = true;
            this.Axonometric.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Axonometric.ForeColor = System.Drawing.Color.Black;
            this.Axonometric.Location = new System.Drawing.Point(3, 84);
            this.Axonometric.Name = "Axonometric";
            this.Axonometric.Size = new System.Drawing.Size(105, 21);
            this.Axonometric.TabIndex = 55;
            this.Axonometric.Text = "Axonometric";
            this.Axonometric.UseVisualStyleBackColor = true;
            this.Axonometric.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // Oblique
            // 
            this.Oblique.AutoSize = true;
            this.Oblique.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oblique.ForeColor = System.Drawing.Color.Black;
            this.Oblique.Location = new System.Drawing.Point(3, 149);
            this.Oblique.Name = "Oblique";
            this.Oblique.Size = new System.Drawing.Size(75, 21);
            this.Oblique.TabIndex = 56;
            this.Oblique.Text = "Oblique";
            this.Oblique.UseVisualStyleBackColor = true;
            this.Oblique.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // l
            // 
            this.l.BackColor = System.Drawing.Color.Silver;
            this.l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(3, 185);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 23);
            this.l.TabIndex = 57;
            this.l.Text = "0,5";
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Silver;
            this.a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.ForeColor = System.Drawing.Color.Black;
            this.a.Location = new System.Drawing.Point(41, 185);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(38, 23);
            this.a.TabIndex = 58;
            this.a.Text = "10";
            // 
            // tet
            // 
            this.tet.AutoSize = true;
            this.tet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tet.Location = new System.Drawing.Point(49, 232);
            this.tet.Name = "tet";
            this.tet.Size = new System.Drawing.Size(16, 17);
            this.tet.TabIndex = 69;
            this.tet.Text = "θ";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f.Location = new System.Drawing.Point(89, 232);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(22, 17);
            this.f.TabIndex = 68;
            this.f.Text = "φ ";
            // 
            // ro
            // 
            this.ro.AutoSize = true;
            this.ro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ro.Location = new System.Drawing.Point(117, 232);
            this.ro.Name = "ro";
            this.ro.Size = new System.Drawing.Size(16, 17);
            this.ro.TabIndex = 67;
            this.ro.Text = "ρ";
            // 
            // roT
            // 
            this.roT.BackColor = System.Drawing.Color.Silver;
            this.roT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roT.ForeColor = System.Drawing.Color.Black;
            this.roT.Location = new System.Drawing.Point(112, 252);
            this.roT.Name = "roT";
            this.roT.Size = new System.Drawing.Size(36, 23);
            this.roT.TabIndex = 65;
            this.roT.Text = "400";
            // 
            // fiT
            // 
            this.fiT.BackColor = System.Drawing.Color.Silver;
            this.fiT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiT.ForeColor = System.Drawing.Color.Black;
            this.fiT.Location = new System.Drawing.Point(77, 252);
            this.fiT.Name = "fiT";
            this.fiT.Size = new System.Drawing.Size(38, 23);
            this.fiT.TabIndex = 66;
            this.fiT.Text = "0";
            // 
            // Dont
            // 
            this.Dont.AutoSize = true;
            this.Dont.Checked = true;
            this.Dont.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dont.ForeColor = System.Drawing.Color.Black;
            this.Dont.Location = new System.Drawing.Point(3, 3);
            this.Dont.Name = "Dont";
            this.Dont.Size = new System.Drawing.Size(70, 21);
            this.Dont.TabIndex = 63;
            this.Dont.TabStop = true;
            this.Dont.Text = "Frontal";
            this.Dont.UseVisualStyleBackColor = true;
            this.Dont.CheckedChanged += new System.EventHandler(this.Button_Click);
            // 
            // tetaT
            // 
            this.tetaT.BackColor = System.Drawing.Color.Silver;
            this.tetaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tetaT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tetaT.ForeColor = System.Drawing.Color.Black;
            this.tetaT.Location = new System.Drawing.Point(41, 252);
            this.tetaT.Name = "tetaT";
            this.tetaT.Size = new System.Drawing.Size(38, 23);
            this.tetaT.TabIndex = 64;
            this.tetaT.Text = "270";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(16, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 17);
            this.label21.TabIndex = 59;
            this.label21.Text = "l";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(51, 165);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(16, 17);
            this.label20.TabIndex = 60;
            this.label20.Text = "α";
            // 
            // Auto
            // 
            this.Auto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Auto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auto.ForeColor = System.Drawing.Color.Black;
            this.Auto.Location = new System.Drawing.Point(3, 525);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(186, 32);
            this.Auto.TabIndex = 63;
            this.Auto.Text = "Auto";
            this.Auto.UseVisualStyleBackColor = false;
            this.Auto.Click += new System.EventHandler(this.Button_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Silver;
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.ForeColor = System.Drawing.Color.Black;
            this.X.Location = new System.Drawing.Point(3, 139);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(34, 23);
            this.X.TabIndex = 70;
            this.X.Text = "1000";
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.Silver;
            this.Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Y.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.ForeColor = System.Drawing.Color.Black;
            this.Y.Location = new System.Drawing.Point(36, 139);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(36, 23);
            this.Y.TabIndex = 71;
            this.Y.Text = "0";
            // 
            // Z
            // 
            this.Z.BackColor = System.Drawing.Color.Silver;
            this.Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Z.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.ForeColor = System.Drawing.Color.Black;
            this.Z.Location = new System.Drawing.Point(72, 139);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(37, 23);
            this.Z.TabIndex = 72;
            this.Z.Text = "0";
            // 
            // Ia
            // 
            this.Ia.BackColor = System.Drawing.Color.Silver;
            this.Ia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ia.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ia.ForeColor = System.Drawing.Color.Black;
            this.Ia.Location = new System.Drawing.Point(71, 93);
            this.Ia.Name = "Ia";
            this.Ia.Size = new System.Drawing.Size(37, 23);
            this.Ia.TabIndex = 73;
            this.Ia.Text = "127";
            // 
            // kd
            // 
            this.kd.BackColor = System.Drawing.Color.Silver;
            this.kd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kd.ForeColor = System.Drawing.Color.Black;
            this.kd.Location = new System.Drawing.Point(2, 93);
            this.kd.Name = "kd";
            this.kd.Size = new System.Drawing.Size(36, 23);
            this.kd.TabIndex = 74;
            this.kd.Text = "1";
            // 
            // Il
            // 
            this.Il.BackColor = System.Drawing.Color.Silver;
            this.Il.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Il.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Il.ForeColor = System.Drawing.Color.Black;
            this.Il.Location = new System.Drawing.Point(35, 93);
            this.Il.Name = "Il";
            this.Il.Size = new System.Drawing.Size(36, 23);
            this.Il.TabIndex = 75;
            this.Il.Text = "127";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Il";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "kd";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(78, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 17);
            this.label18.TabIndex = 76;
            this.label18.Text = "Ia";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(12, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 77;
            this.label19.Text = "X";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(82, 119);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 17);
            this.label22.TabIndex = 78;
            this.label22.Text = "Z";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(44, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 17);
            this.label23.TabIndex = 79;
            this.label23.Text = "Y";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(710, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 589);
            this.tabControl1.TabIndex = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Auto);
            this.tabPage1.Controls.Add(this.Rotate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Approximation);
            this.tabPage1.Controls.Add(this.Radius2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.Height);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.Radius1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gama);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Sz);
            this.tabPage1.Controls.Add(this.Dz);
            this.tabPage1.Controls.Add(this.alpha);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.Dx);
            this.tabPage1.Controls.Add(this.beta);
            this.tabPage1.Controls.Add(this.Sx);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Dy);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Sy);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.LightCoral;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tet);
            this.panel2.Controls.Add(this.a);
            this.panel2.Controls.Add(this.f);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.ro);
            this.panel2.Controls.Add(this.Psi);
            this.panel2.Controls.Add(this.roT);
            this.panel2.Controls.Add(this.l);
            this.panel2.Controls.Add(this.fiT);
            this.panel2.Controls.Add(this.d);
            this.panel2.Controls.Add(this.Dont);
            this.panel2.Controls.Add(this.Oblique);
            this.panel2.Controls.Add(this.Lol);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tetaT);
            this.panel2.Controls.Add(this.Axonometric);
            this.panel2.Controls.Add(this.Horizontal);
            this.panel2.Controls.Add(this.Fi);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.Profile);
            this.panel2.Controls.Add(this.Perspective);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(2, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 282);
            this.panel2.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.polygon);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.Il);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Z);
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.kd);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.Y);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Ia);
            this.panel1.Location = new System.Drawing.Point(2, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 180);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picture);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Sx;
        private System.Windows.Forms.TextBox Sy;
        private System.Windows.Forms.TextBox Sz;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.TextBox gama;
        private System.Windows.Forms.TextBox beta;
        private System.Windows.Forms.TextBox Dx;
        private System.Windows.Forms.TextBox Dy;
        private System.Windows.Forms.TextBox Dz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Radius2;
        private System.Windows.Forms.TextBox Approximation;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Radius1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox Fi;
        private System.Windows.Forms.TextBox Psi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Label Lol;
        private System.Windows.Forms.RadioButton polygon;
        private System.Windows.Forms.RadioButton Horizontal;
        private System.Windows.Forms.RadioButton Profile;
        private System.Windows.Forms.RadioButton Perspective;
        private System.Windows.Forms.RadioButton Axonometric;
        private System.Windows.Forms.RadioButton Oblique;
        private System.Windows.Forms.TextBox l;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.RadioButton Dont;
        private System.Windows.Forms.Button Auto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tetaT;
        private System.Windows.Forms.TextBox roT;
        private System.Windows.Forms.TextBox fiT;
        private System.Windows.Forms.Label tet;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label ro;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox Z;
        private System.Windows.Forms.TextBox Ia;
        private System.Windows.Forms.TextBox kd;
        private System.Windows.Forms.TextBox Il;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

