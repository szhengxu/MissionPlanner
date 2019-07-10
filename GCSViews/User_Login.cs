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
        private static string lastpagename = "";

        public User_Login()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            InitializeComponent();
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
    }
}