namespace CPU_Counter
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.lbl2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter3 = new System.Diagnostics.PerformanceCounter();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.performanceCounter4 = new System.Diagnostics.PerformanceCounter();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lbl5 = new System.Windows.Forms.Label();
            this.performanceCounter5 = new System.Diagnostics.PerformanceCounter();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter6 = new System.Diagnostics.PerformanceCounter();
            this.lbl6 = new System.Windows.Forms.Label();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter8 = new System.Diagnostics.PerformanceCounter();
            this.lbl8 = new System.Windows.Forms.Label();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter9 = new System.Diagnostics.PerformanceCounter();
            this.lbl9 = new System.Windows.Forms.Label();
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter10 = new System.Diagnostics.PerformanceCounter();
            this.lbl10 = new System.Windows.Forms.Label();
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cORE1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cORE2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cORE3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cORE4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hDDInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter7 = new System.Diagnostics.PerformanceCounter();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter10)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter7)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl1.Location = new System.Drawing.Point(12, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(91, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Total usage";
            this.toolTip1.SetToolTip(this.lbl1, "Total load on CPU");
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Processor";
            this.performanceCounter2.CounterName = "% Processor Time";
            this.performanceCounter2.InstanceName = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2.Location = new System.Drawing.Point(12, 65);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(66, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "CORE#1";
            this.toolTip1.SetToolTip(this.lbl2, "Load on core #1");
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // performanceCounter3
            // 
            this.performanceCounter3.CategoryName = "Processor";
            this.performanceCounter3.CounterName = "% Processor Time";
            this.performanceCounter3.InstanceName = "1";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl3.Location = new System.Drawing.Point(12, 92);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(66, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "CORE#2";
            this.toolTip1.SetToolTip(this.lbl3, "Load on core #2");
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl4.Location = new System.Drawing.Point(12, 119);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(66, 16);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "CORE#3";
            this.toolTip1.SetToolTip(this.lbl4, "Load on core #3");
            // 
            // performanceCounter4
            // 
            this.performanceCounter4.CategoryName = "Processor";
            this.performanceCounter4.CounterName = "% Processor Time";
            this.performanceCounter4.InstanceName = "2";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl5.Location = new System.Drawing.Point(12, 145);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(66, 16);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "CORE#4";
            this.toolTip1.SetToolTip(this.lbl5, "Load on core #4");
            // 
            // performanceCounter5
            // 
            this.performanceCounter5.CategoryName = "Processor";
            this.performanceCounter5.CounterName = "% Processor Time";
            this.performanceCounter5.InstanceName = "3";
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // performanceCounter6
            // 
            this.performanceCounter6.CategoryName = "Memory";
            this.performanceCounter6.CounterName = "Available MBytes";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl6.Location = new System.Drawing.Point(304, 38);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(63, 16);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "memory";
            this.toolTip1.SetToolTip(this.lbl6, "Amount of free RAM memory");
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // performanceCounter8
            // 
            this.performanceCounter8.CategoryName = "System";
            this.performanceCounter8.CounterName = "System Up Time";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl8.Location = new System.Drawing.Point(304, 65);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(58, 16);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "up time";
            this.toolTip1.SetToolTip(this.lbl8, "Show how long has the computer been operational");
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Interval = 1000;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // performanceCounter9
            // 
            this.performanceCounter9.CategoryName = "System";
            this.performanceCounter9.CounterName = "Processes";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.Transparent;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl9.Location = new System.Drawing.Point(12, 172);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(82, 16);
            this.lbl9.TabIndex = 8;
            this.lbl9.Text = "Processes";
            this.toolTip1.SetToolTip(this.lbl9, "Shows all active processes at the moment");
            // 
            // timer9
            // 
            this.timer9.Enabled = true;
            this.timer9.Interval = 1000;
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // performanceCounter10
            // 
            this.performanceCounter10.CategoryName = "System";
            this.performanceCounter10.CounterName = "Threads";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Transparent;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl10.Location = new System.Drawing.Point(12, 202);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(60, 16);
            this.lbl10.TabIndex = 9;
            this.lbl10.Text = "threads";
            this.toolTip1.SetToolTip(this.lbl10, "Shows all active threads");
            // 
            // timer10
            // 
            this.timer10.Enabled = true;
            this.timer10.Interval = 1000;
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(503, 92);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "SAVE";
            this.toolTip1.SetToolTip(this.btn1, "Press for saving the data");
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Coral;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(524, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 18);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "STOP";
            this.toolTip1.SetToolTip(this.radioButton1, "Press for pausing the counters");
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(524, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 18);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "RUN";
            this.toolTip1.SetToolTip(this.radioButton2, "Press for starting the counters");
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgramToolStripMenuItem,
            this.versionHistoryToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutTheProgramToolStripMenuItem.Text = "About the program";
            this.aboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTheProgramToolStripMenuItem_Click);
            // 
            // versionHistoryToolStripMenuItem
            // 
            this.versionHistoryToolStripMenuItem.Name = "versionHistoryToolStripMenuItem";
            this.versionHistoryToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.versionHistoryToolStripMenuItem.Text = "Version History";
            this.versionHistoryToolStripMenuItem.Click += new System.EventHandler(this.versionHistoryToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualPreviewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // visualPreviewToolStripMenuItem
            // 
            this.visualPreviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalUsageToolStripMenuItem,
            this.cORE1ToolStripMenuItem,
            this.cORE2ToolStripMenuItem,
            this.cORE3ToolStripMenuItem,
            this.cORE4ToolStripMenuItem});
            this.visualPreviewToolStripMenuItem.Name = "visualPreviewToolStripMenuItem";
            this.visualPreviewToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.visualPreviewToolStripMenuItem.Text = "Visual preview";
            // 
            // totalUsageToolStripMenuItem
            // 
            this.totalUsageToolStripMenuItem.Name = "totalUsageToolStripMenuItem";
            this.totalUsageToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.totalUsageToolStripMenuItem.Text = "Total Usage";
            this.totalUsageToolStripMenuItem.Click += new System.EventHandler(this.totalUsageToolStripMenuItem_Click);
            // 
            // cORE1ToolStripMenuItem
            // 
            this.cORE1ToolStripMenuItem.Name = "cORE1ToolStripMenuItem";
            this.cORE1ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cORE1ToolStripMenuItem.Text = "CORE#1";
            this.cORE1ToolStripMenuItem.Click += new System.EventHandler(this.cORE1ToolStripMenuItem_Click);
            // 
            // cORE2ToolStripMenuItem
            // 
            this.cORE2ToolStripMenuItem.Name = "cORE2ToolStripMenuItem";
            this.cORE2ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cORE2ToolStripMenuItem.Text = "CORE#2";
            this.cORE2ToolStripMenuItem.Click += new System.EventHandler(this.cORE2ToolStripMenuItem_Click);
            // 
            // cORE3ToolStripMenuItem
            // 
            this.cORE3ToolStripMenuItem.Name = "cORE3ToolStripMenuItem";
            this.cORE3ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cORE3ToolStripMenuItem.Text = "CORE#3";
            this.cORE3ToolStripMenuItem.Click += new System.EventHandler(this.cORE3ToolStripMenuItem_Click);
            // 
            // cORE4ToolStripMenuItem
            // 
            this.cORE4ToolStripMenuItem.Name = "cORE4ToolStripMenuItem";
            this.cORE4ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cORE4ToolStripMenuItem.Text = "CORE#4";
            this.cORE4ToolStripMenuItem.Click += new System.EventHandler(this.cORE4ToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hDDInfoToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // hDDInfoToolStripMenuItem
            // 
            this.hDDInfoToolStripMenuItem.Name = "hDDInfoToolStripMenuItem";
            this.hDDInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.hDDInfoToolStripMenuItem.Text = "HDD info";
            this.hDDInfoToolStripMenuItem.Click += new System.EventHandler(this.hDDInfoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 367);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer11
            // 
            this.timer11.Enabled = true;
            this.timer11.Interval = 1000;
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // performanceCounter7
            // 
            this.performanceCounter7.CategoryName = "PhysicalDisk";
            this.performanceCounter7.CounterName = "% Disk Read Time";
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 1000;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(304, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "system";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(594, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "System Overview v1.3";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter10)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Timer timer2;
        private System.Diagnostics.PerformanceCounter performanceCounter3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Diagnostics.PerformanceCounter performanceCounter4;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lbl5;
        private System.Diagnostics.PerformanceCounter performanceCounter5;
        private System.Windows.Forms.Timer timer5;
        private System.Diagnostics.PerformanceCounter performanceCounter6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Timer timer6;
        private System.Diagnostics.PerformanceCounter performanceCounter8;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Timer timer8;
        private System.Diagnostics.PerformanceCounter performanceCounter9;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Timer timer9;
        private System.Diagnostics.PerformanceCounter performanceCounter10;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cORE1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cORE2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cORE3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cORE4ToolStripMenuItem;
        private System.Diagnostics.PerformanceCounter performanceCounter7;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hDDInfoToolStripMenuItem;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Label label1;
    }
}

