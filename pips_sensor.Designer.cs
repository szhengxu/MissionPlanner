namespace MissionPlanner
{
    partial class pips_sensor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BUT_savecsv2 = new MissionPlanner.Controls.MyButton();
            this.zg2 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.zg3 = new ZedGraph.ZedGraphControl();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.myButton5 = new MissionPlanner.Controls.MyButton();
            this.myButton6 = new MissionPlanner.Controls.MyButton();
            this.myButton7 = new MissionPlanner.Controls.MyButton();
            this.myButton8 = new MissionPlanner.Controls.MyButton();
            this.myButton9 = new MissionPlanner.Controls.MyButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.myButton4 = new MissionPlanner.Controls.MyButton();
            this.myButton10 = new MissionPlanner.Controls.MyButton();
            this.myButton11 = new MissionPlanner.Controls.MyButton();
            this.myButton12 = new MissionPlanner.Controls.MyButton();
            this.myButton13 = new MissionPlanner.Controls.MyButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.myButton14 = new MissionPlanner.Controls.MyButton();
            this.myButton15 = new MissionPlanner.Controls.MyButton();
            this.myButton16 = new MissionPlanner.Controls.MyButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(874, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 73);
            this.textBox1.TabIndex = 38;
            // 
            // BUT_savecsv2
            // 
            this.BUT_savecsv2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_savecsv2.Location = new System.Drawing.Point(724, 68);
            this.BUT_savecsv2.Name = "BUT_savecsv2";
            this.BUT_savecsv2.Size = new System.Drawing.Size(84, 24);
            this.BUT_savecsv2.TabIndex = 48;
            this.BUT_savecsv2.Text = "开始记录";
            this.BUT_savecsv2.UseVisualStyleBackColor = true;
            this.BUT_savecsv2.Click += new System.EventHandler(this.BUT_savecsv2_Click);
            // 
            // zg2
            // 
            this.zg2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zg2.AutoSize = true;
            this.zg2.BackColor = System.Drawing.Color.Transparent;
            this.zg2.Location = new System.Drawing.Point(0, 101);
            this.zg2.Name = "zg2";
            this.zg2.ScrollGrace = 0D;
            this.zg2.ScrollMaxX = 0D;
            this.zg2.ScrollMaxY = 0D;
            this.zg2.ScrollMaxY2 = 0D;
            this.zg2.ScrollMinX = 0D;
            this.zg2.ScrollMinY = 0D;
            this.zg2.ScrollMinY2 = 0D;
            this.zg2.Size = new System.Drawing.Size(694, 547);
            this.zg2.TabIndex = 47;
            this.zg2.Load += new System.EventHandler(this.zg2_Load);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // zg3
            // 
            this.zg3.AutoSize = true;
            this.zg3.BackColor = System.Drawing.Color.Transparent;
            this.zg3.Location = new System.Drawing.Point(668, 101);
            this.zg3.Name = "zg3";
            this.zg3.ScrollGrace = 0D;
            this.zg3.ScrollMaxX = 0D;
            this.zg3.ScrollMaxY = 0D;
            this.zg3.ScrollMaxY2 = 0D;
            this.zg3.ScrollMinX = 0D;
            this.zg3.ScrollMinY = 0D;
            this.zg3.ScrollMinY2 = 0D;
            this.zg3.Size = new System.Drawing.Size(673, 547);
            this.zg3.TabIndex = 49;
            // 
            // myButton1
            // 
            this.myButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton1.Location = new System.Drawing.Point(480, 36);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(84, 24);
            this.myButton1.TabIndex = 50;
            this.myButton1.Text = "测试通讯";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton2.Location = new System.Drawing.Point(6, 6);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(84, 24);
            this.myButton2.TabIndex = 51;
            this.myButton2.Text = "启动数据采集";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton3
            // 
            this.myButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton3.Location = new System.Drawing.Point(6, 36);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(84, 24);
            this.myButton3.TabIndex = 52;
            this.myButton3.Text = "停止数据采集";
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton5
            // 
            this.myButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton5.Location = new System.Drawing.Point(604, 8);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(84, 24);
            this.myButton5.TabIndex = 54;
            this.myButton5.Text = "设置符合模式";
            this.myButton5.UseVisualStyleBackColor = true;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // myButton6
            // 
            this.myButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton6.Location = new System.Drawing.Point(174, 6);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(84, 24);
            this.myButton6.TabIndex = 55;
            this.myButton6.Text = "设置探头高压";
            this.myButton6.UseVisualStyleBackColor = true;
            this.myButton6.Click += new System.EventHandler(this.myButton6_Click);
            // 
            // myButton7
            // 
            this.myButton7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton7.Location = new System.Drawing.Point(174, 36);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(84, 24);
            this.myButton7.TabIndex = 56;
            this.myButton7.Text = "设置甄别阈值";
            this.myButton7.UseVisualStyleBackColor = true;
            this.myButton7.Click += new System.EventHandler(this.myButton7_Click);
            // 
            // myButton8
            // 
            this.myButton8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton8.Location = new System.Drawing.Point(390, 6);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(84, 24);
            this.myButton8.TabIndex = 57;
            this.myButton8.Text = "设置调试模式";
            this.myButton8.UseVisualStyleBackColor = true;
            this.myButton8.Click += new System.EventHandler(this.myButton8_Click);
            // 
            // myButton9
            // 
            this.myButton9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton9.Location = new System.Drawing.Point(390, 36);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(84, 24);
            this.myButton9.TabIndex = 58;
            this.myButton9.Text = "脉冲模式";
            this.myButton9.UseVisualStyleBackColor = true;
            this.myButton9.Click += new System.EventHandler(this.myButton9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(103, 35);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 24);
            this.textBox3.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(103, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 24);
            this.textBox2.TabIndex = 61;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 48;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "正常采集模式",
            "debug模式"});
            this.comboBox1.Location = new System.Drawing.Point(264, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 24);
            this.comboBox1.TabIndex = 62;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 48;
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Items.AddRange(new object[] {
            "脉冲幅度谱模式",
            "单个脉冲模式"});
            this.comboBox2.Location = new System.Drawing.Point(264, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 24);
            this.comboBox2.TabIndex = 63;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownHeight = 48;
            this.comboBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.Items.AddRange(new object[] {
            "反符合模式",
            "符合模式"});
            this.comboBox3.Location = new System.Drawing.Point(480, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(118, 24);
            this.comboBox3.TabIndex = 64;
            // 
            // myButton4
            // 
            this.myButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton4.Location = new System.Drawing.Point(724, 22);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(69, 40);
            this.myButton4.TabIndex = 65;
            this.myButton4.Text = "开始";
            this.myButton4.UseVisualStyleBackColor = true;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton10
            // 
            this.myButton10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton10.Location = new System.Drawing.Point(799, 22);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(69, 40);
            this.myButton10.TabIndex = 66;
            this.myButton10.Text = "停止";
            this.myButton10.UseVisualStyleBackColor = true;
            this.myButton10.Click += new System.EventHandler(this.myButton10_Click);
            // 
            // myButton11
            // 
            this.myButton11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton11.Location = new System.Drawing.Point(207, 36);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(84, 24);
            this.myButton11.TabIndex = 67;
            this.myButton11.Text = "测试通讯";
            this.myButton11.UseVisualStyleBackColor = true;
            this.myButton11.Click += new System.EventHandler(this.myButton11_Click);
            // 
            // myButton12
            // 
            this.myButton12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton12.Location = new System.Drawing.Point(6, 6);
            this.myButton12.Name = "myButton12";
            this.myButton12.Size = new System.Drawing.Size(84, 24);
            this.myButton12.TabIndex = 68;
            this.myButton12.Text = "启动泵";
            this.myButton12.UseVisualStyleBackColor = true;
            this.myButton12.Click += new System.EventHandler(this.myButton12_Click);
            // 
            // myButton13
            // 
            this.myButton13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton13.Location = new System.Drawing.Point(6, 36);
            this.myButton13.Name = "myButton13";
            this.myButton13.Size = new System.Drawing.Size(84, 24);
            this.myButton13.TabIndex = 69;
            this.myButton13.Text = "关闭泵";
            this.myButton13.UseVisualStyleBackColor = true;
            this.myButton13.Click += new System.EventHandler(this.myButton13_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownHeight = 48;
            this.comboBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0",
            "6.5",
            "7.0",
            "7.5",
            "8.0",
            "8.5",
            "9.0",
            "9.5",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(207, 6);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(65, 24);
            this.comboBox4.TabIndex = 70;
            // 
            // myButton14
            // 
            this.myButton14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton14.Location = new System.Drawing.Point(278, 6);
            this.myButton14.Name = "myButton14";
            this.myButton14.Size = new System.Drawing.Size(84, 24);
            this.myButton14.TabIndex = 71;
            this.myButton14.Text = "流量值间隔";
            this.myButton14.UseVisualStyleBackColor = true;
            this.myButton14.Click += new System.EventHandler(this.myButton14_Click);
            // 
            // myButton15
            // 
            this.myButton15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton15.Location = new System.Drawing.Point(109, 6);
            this.myButton15.Name = "myButton15";
            this.myButton15.Size = new System.Drawing.Size(84, 24);
            this.myButton15.TabIndex = 72;
            this.myButton15.Text = "开始发送数据";
            this.myButton15.UseVisualStyleBackColor = true;
            this.myButton15.Click += new System.EventHandler(this.myButton15_Click);
            // 
            // myButton16
            // 
            this.myButton16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton16.Location = new System.Drawing.Point(109, 36);
            this.myButton16.Name = "myButton16";
            this.myButton16.Size = new System.Drawing.Size(84, 24);
            this.myButton16.TabIndex = 73;
            this.myButton16.Text = "停止发送数据";
            this.myButton16.UseVisualStyleBackColor = true;
            this.myButton16.Click += new System.EventHandler(this.myButton16_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 97);
            this.tabControl1.TabIndex = 74;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.myButton2);
            this.tabPage1.Controls.Add(this.myButton1);
            this.tabPage1.Controls.Add(this.myButton3);
            this.tabPage1.Controls.Add(this.myButton5);
            this.tabPage1.Controls.Add(this.myButton6);
            this.tabPage1.Controls.Add(this.myButton7);
            this.tabPage1.Controls.Add(this.myButton8);
            this.tabPage1.Controls.Add(this.myButton9);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PIPS多通道探测器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.myButton12);
            this.tabPage2.Controls.Add(this.myButton11);
            this.tabPage2.Controls.Add(this.myButton14);
            this.tabPage2.Controls.Add(this.myButton16);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.myButton13);
            this.tabPage2.Controls.Add(this.myButton15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1253, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "气体流量探测系统";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pips_sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 649);
            this.Controls.Add(this.zg2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.myButton10);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.BUT_savecsv2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zg3);
            this.Name = "pips_sensor";
            this.Text = "pips_sensor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Controls.MyButton BUT_savecsv2;
        private ZedGraph.ZedGraphControl zg2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ZedGraph.ZedGraphControl zg3;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
        private Controls.MyButton myButton5;
        private Controls.MyButton myButton6;
        private Controls.MyButton myButton7;
        private Controls.MyButton myButton8;
        private Controls.MyButton myButton9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private Controls.MyButton myButton4;
        private Controls.MyButton myButton10;
        private Controls.MyButton myButton11;
        private Controls.MyButton myButton12;
        private Controls.MyButton myButton13;
        private System.Windows.Forms.ComboBox comboBox4;
        private Controls.MyButton myButton14;
        private Controls.MyButton myButton15;
        private Controls.MyButton myButton16;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}