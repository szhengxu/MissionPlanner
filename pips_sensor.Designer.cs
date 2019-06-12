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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 199);
            this.textBox1.TabIndex = 38;
            // 
            // BUT_savecsv2
            // 
            this.BUT_savecsv2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_savecsv2.Location = new System.Drawing.Point(610, 22);
            this.BUT_savecsv2.Name = "BUT_savecsv2";
            this.BUT_savecsv2.Size = new System.Drawing.Size(84, 24);
            this.BUT_savecsv2.TabIndex = 48;
            this.BUT_savecsv2.Text = "Save CSV";
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
            this.zg2.Location = new System.Drawing.Point(0, 216);
            this.zg2.Name = "zg2";
            this.zg2.ScrollGrace = 0D;
            this.zg2.ScrollMaxX = 0D;
            this.zg2.ScrollMaxY = 0D;
            this.zg2.ScrollMaxY2 = 0D;
            this.zg2.ScrollMinX = 0D;
            this.zg2.ScrollMinY = 0D;
            this.zg2.ScrollMinY2 = 0D;
            this.zg2.Size = new System.Drawing.Size(754, 459);
            this.zg2.TabIndex = 47;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // zg3
            // 
            this.zg3.AutoSize = true;
            this.zg3.BackColor = System.Drawing.Color.Transparent;
            this.zg3.Location = new System.Drawing.Point(753, 216);
            this.zg3.Name = "zg3";
            this.zg3.ScrollGrace = 0D;
            this.zg3.ScrollMaxX = 0D;
            this.zg3.ScrollMaxY = 0D;
            this.zg3.ScrollMaxY2 = 0D;
            this.zg3.ScrollMinX = 0D;
            this.zg3.ScrollMinY = 0D;
            this.zg3.ScrollMinY2 = 0D;
            this.zg3.Size = new System.Drawing.Size(753, 459);
            this.zg3.TabIndex = 49;
            // 
            // myButton1
            // 
            this.myButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton1.Location = new System.Drawing.Point(1092, 79);
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
            this.myButton2.Location = new System.Drawing.Point(931, 22);
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
            this.myButton3.Location = new System.Drawing.Point(931, 52);
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
            this.myButton5.Location = new System.Drawing.Point(1317, 79);
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
            this.myButton6.Location = new System.Drawing.Point(1093, 22);
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
            this.myButton7.Location = new System.Drawing.Point(1093, 52);
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
            this.myButton8.Location = new System.Drawing.Point(1317, 19);
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
            this.myButton9.Location = new System.Drawing.Point(1317, 49);
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
            this.textBox3.Location = new System.Drawing.Point(1021, 52);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 24);
            this.textBox3.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(1021, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(1183, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 24);
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
            this.comboBox2.Location = new System.Drawing.Point(1183, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 24);
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
            this.comboBox3.Location = new System.Drawing.Point(1183, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(127, 24);
            this.comboBox3.TabIndex = 64;
            // 
            // myButton4
            // 
            this.myButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton4.Location = new System.Drawing.Point(753, 36);
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
            this.myButton10.Location = new System.Drawing.Point(753, 94);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(69, 40);
            this.myButton10.TabIndex = 66;
            this.myButton10.Text = "停止";
            this.myButton10.UseVisualStyleBackColor = true;
            this.myButton10.Click += new System.EventHandler(this.myButton10_Click);
            // 
            // pips_sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 674);
            this.Controls.Add(this.myButton10);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.myButton9);
            this.Controls.Add(this.myButton8);
            this.Controls.Add(this.myButton7);
            this.Controls.Add(this.myButton6);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.BUT_savecsv2);
            this.Controls.Add(this.zg2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zg3);
            this.Name = "pips_sensor";
            this.Text = "pips_sensor";
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
    }
}