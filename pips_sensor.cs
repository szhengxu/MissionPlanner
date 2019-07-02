using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZedGraph;
using AGaugeApp;
using System.IO.Ports;
using System.Threading;
using MissionPlanner.Utilities;
using MissionPlanner.Mavlink;

namespace MissionPlanner
{
    public partial class pips_sensor : Form
    {
        RollingPointPairList list_last = new RollingPointPairList(1024);
        RollingPointPairList list_now  = new RollingPointPairList(1024);

        object thisLock = new object();
        int tickStart = 0;
        bool update_plot = false;


        public pips_sensor()
        {
            InitializeComponent();
            CreateChart_pips_last(zg2, "溴化镧能谱表-last", "频率", "幅值");
            CreateChart_pips_now (zg3, "溴化镧能谱表-now", "频率", "幅值");
            MissionPlanner.Utilities.Tracking.AddPage(this.GetType().ToString(), this.Text);
        }

        public struct plot
        {
            public string Name;
            public RollingPointPairList PointList;
            public Color color;
        }

        public void CreateChart_pips_now(ZedGraphControl zgc, string Title, string XAxis, string YAxis)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = Title;
            myPane.XAxis.Title.Text = XAxis;
            myPane.YAxis.Title.Text = YAxis;

            LineItem pips;

            pips = myPane.AddCurve("pips", list_now, Color.Red, SymbolType.None);

            // Show the x axis grid
            myPane.XAxis.MajorGrid.IsVisible = true;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 1024;

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = true;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;
            // Manually set the axis range
            //myPane.YAxis.Scale.Min = -1;
            //myPane.YAxis.Scale.Max = 1;

            // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // Sample at 500ms intervals
            timer1.Interval = 200;
            timer1.Enabled = true;
            timer1.Start();


            // Calculate the Axis Scale Ranges
            zgc.AxisChange();

            tickStart = Environment.TickCount;
        }

        public void CreateChart_pips_last(ZedGraphControl zgc, string Title, string XAxis, string YAxis)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = Title;
            myPane.XAxis.Title.Text = XAxis;
            myPane.YAxis.Title.Text = YAxis;

            LineItem pips;

            pips = myPane.AddCurve("pips", list_last, Color.Red, SymbolType.None);

            // Show the x axis grid
            myPane.XAxis.MajorGrid.IsVisible = true;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 1024;

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = true;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;
            // Manually set the axis range
            //myPane.YAxis.Scale.Min = -1;
            //myPane.YAxis.Scale.Max = 1;

            // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // Sample at 500ms intervals
            timer1.Interval = 200;
            timer1.Enabled = true;
            timer1.Start();


            // Calculate the Axis Scale Ranges
            zgc.AxisChange();

            tickStart = Environment.TickCount;
        }

        System.IO.StreamWriter sw = null;
        private void BUT_savecsv2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.AddExtension = true;
                ofd.DefaultExt = ".csv";
                var result = ofd.ShowDialog();
                if (ofd.FileName != "" && result == DialogResult.OK)
                {
                    try
                    {
                        if (sw != null)
                            sw.Close();
                    }
                    catch
                    {
                    }

                    sw = new System.IO.StreamWriter(ofd.OpenFile());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (update_plot == false)
            {
                return;
            }
            double time = (Environment.TickCount - tickStart) / 1000.0;

            // Make sure that the curvelist has at least one curve
            if (zg2.GraphPane == null || zg3.GraphPane == null)
                return;

            // Get the first CurveItem in the graph
            LineItem curve = zg3.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;

            // Get the PointPairList
            IPointListEdit list = curve.Points as IPointListEdit;
            // If this is null, it means the reference at curve.Points does not
            // support IPointListEdit, so we won't be able to modify it
            if (list == null)
                return;

            // Time is measured in seconds
            //double time = (Environment.TickCount - tickStart) / 1000.0;

            // Keep the X scale at a rolling 30 second interval, with one
            // major step between the max X value and the end of the axis
            //Scale xScale = zg3.GraphPane.XAxis.Scale;
            //if (time > xScale.Max - xScale.MajorStep)
            //{
            //    xScale.Max = time + xScale.MajorStep;
            //    xScale.Min = xScale.Max - 10.0;
            //}

            //xScale.Min = tickStart/1000;
            //xScale.Max = tickStart/1000 +1024;



            // Make sure the Y axis is rescaled to accommodate actual data
            try
            {
                zg2.AxisChange();
                zg3.AxisChange();
            }
            catch
            {
            }
            // Force a redraw
            zg2.Invalidate();
            zg3.Invalidate();
        }

        Random random = new Random();
        int rx_count = 0;
        public byte[] pips_now  = new byte[1024];
        public byte[] pips_last = new byte[1024];
        byte ms50=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen && !MainV2.comPort.logreadmode)
                return;

            if (MainV2.comPort.MAV.cs.f1024 == 1)
            {
                //test
                MainV2.comPort.MAV.cs.f1024 = 0;
                rx_count++;
                //textBox1.AppendText(rx_count + ".RX:" + System.Text.Encoding.ASCII.GetString(MainV2.comPort.MAV.cs.pips_last) + "\r\n");
                textBox1.AppendText(rx_count + ".RX:" + MainV2.comPort.MAV.cs.pips_last.Length + " data ");
                textBox1.AppendText("\r\n");
                //wirte log
                if (sw != null && sw.BaseStream.CanWrite)
                {
                    //time__rx_count__1024个数据
                    for (int i = 0; i < 1024; i++)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2}",DateTime.Now.ToString(),rx_count,MainV2.comPort.MAV.cs.pips_last[i]));
                    }
                }

                //plot
                double time = (Environment.TickCount - tickStart) / 1000.0;
                for (int i = 0; i < 1024; i++)
                {
                    list_now.Add(i, MissionPlanner.MainV2.comPort.MAV.cs.pips_last[i]);
                    list_last.Add(i, pips_last[i]);
                }
                Array.Copy(MissionPlanner.MainV2.comPort.MAV.cs.pips_last, 0, pips_last, 0, 1024);
                update_plot = true;
            }

            if (MainV2.comPort.MAV.cs.cmd96 == 1)
            {
                MainV2.comPort.MAV.cs.cmd96 = 0;
                rx_count++;
                textBox1.AppendText(rx_count + ".RX:" + System.Text.Encoding.ASCII.GetString(MainV2.comPort.MAV.cs.cmd_callback));
                textBox1.AppendText("\r\n");
            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;
            
            data96.data[count] = (byte) '#'; count++;
            data96.data[count] = (byte) 'K'; count++;
            data96.data[count] = (byte) '\n'; count++;

            data96.type = 100;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'Q'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 100;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'S'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 100;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            if (textBox2.TextLength == 3)
            {
                int vol = int.Parse(textBox2.Text); ;
                data96.data[count] = (byte)'#'; count++;
                data96.data[count] = (byte)'V'; count++;
                data96.data[count] = (byte)((vol % 1000) / 100 + 0x30); count++;
                data96.data[count] = (byte)((vol % 100) / 10 + 0x30); count++;
                data96.data[count] = (byte)(vol % 10 + 0x30); count++;
                data96.data[count] = (byte)'\n'; count++;

                data96.type = 100;
                data96.len = count;
                MainV2.comPort.send_data96(data96);
            }
            else
            {
                MessageBox.Show("请输入3位电压数据");
            }
        }

        private void myButton7_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            if (textBox2.TextLength == 3)
            {
                int vol = int.Parse(textBox3.Text); ;
                data96.data[count] = (byte)'#'; count++;
                data96.data[count] = (byte)'V'; count++;
                data96.data[count] = (byte)((vol % 10000) / 1000 + 0x30); count++;
                data96.data[count] = (byte)((vol % 1000) / 100 + 0x30); count++;
                data96.data[count] = (byte)((vol % 100) / 10 + 0x30); count++;
                data96.data[count] = (byte)(vol % 10 + 0x30); count++;
                data96.data[count] = (byte)'\n'; count++;

                data96.type = 100;
                data96.len = count;
                MainV2.comPort.send_data96(data96);
            }
            else
            {
                MessageBox.Show("请输入4位甄别阈值");
            }
        }

        private void myButton8_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'D'; count++;
            data96.data[count] = (byte)(comboBox1.SelectedIndex+0x30); count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 100;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton9_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'A'; count++;
            data96.data[count] = (byte)(comboBox2.SelectedIndex+0x30); count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 100;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'C'; count++;
            data96.data[count] = (byte)(comboBox3.SelectedIndex+0x30); count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 100;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];

            data96.data[0] = 1;
            data96.type = 101;
            data96.len = 1;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton10_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];

            data96.data[0] = 0;
            data96.type = 101;
            data96.len = 1;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton11_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'Q'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 110;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton12_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'O'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 110;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton13_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'S'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 110;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton14_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'D'; count++;

            int time = comboBox4.SelectedIndex * 5 + 5;
            byte time_b = 0;

            time_b = (byte)((time % 1000) / 100);
            if (time_b != 0)
            {
                data96.data[count] = (byte)(time_b + 0x30); count++;
            }
            time_b = (byte)((time % 100) / 10);
            if (time_b != 0)
            {
                data96.data[count] = (byte)(time_b + 0x30); count++;
            }
            time_b = (byte)((time % 10) / 1);
            if (time_b != 0)
            {
                data96.data[count] = (byte)(time_b + 0x30); count++;
            }
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 110;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton15_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'M'; count++;
            data96.data[count] = (byte)'1'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 110;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }

        private void myButton16_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_data96_t data96 = new MAVLink.mavlink_data96_t();
            data96.data = new byte[96];
            byte count = 0;

            data96.data[count] = (byte)'#'; count++;
            data96.data[count] = (byte)'M'; count++;
            data96.data[count] = (byte)'0'; count++;
            data96.data[count] = (byte)'\n'; count++;

            data96.type = 110;
            data96.len = count;
            MainV2.comPort.send_data96(data96);
        }
    }
}
