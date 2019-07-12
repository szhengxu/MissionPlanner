using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using MissionPlanner.ArduPilot;
using MissionPlanner.Controls;
using MissionPlanner.Controls.BackstageView;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Utilities;

namespace MissionPlanner.GCSViews
{
    public partial class User_Login : MyUserControl, IActivate
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public User_Login()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            //InitializeComponent();
        }

        private void User_Login_Load(object sender, EventArgs e)
        {
 
        }

        private void User_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
 
        }

        private void backstageView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBox1.Text.ToString(), "uestc") &&
                string.Equals(textBox2.Text.ToString(), "uestc"))
            {
                MainV2.passed = true;
                label3.Text = "登陆成功！";
            }
            else
            {
                MessageBox.Show("用户名或者密码错误！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainV2.passed = false;
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "退出登陆！";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}