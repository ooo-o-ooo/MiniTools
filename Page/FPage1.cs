
using Sunny.UI;
using MiniTools.Tools;
using System;
using static MiniTools.Tools.RegistryHelper;

namespace MiniTools.Page
{
    public partial class FPage1 : UIPage
    {

        RegistryHelper registrer = new RegistryHelper();
        public FPage1()
        {
            InitializeComponent();
        }

        private void FPage1_Load(object sender, EventArgs e)
        {
            string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
            string keyName = "29";
            object info = registrer.ReadValue(keyName, subKey, RegDomain.LocalMachine);
            Console.WriteLine("==============================");
            Console.WriteLine(Convert.ToString(info));
            ///if (info != null)
            if (uiSwitch1.Active)
                {
                uiSwitch1.Active = true;
                uiLabel1.Text = "当前状态：已去除";

            }
            else
            {`
                uiSwitch1.Active = false;
                uiLabel1.Text = "当前状态：已恢复";


            }
        }
       
        private void uiSwitch1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.ShowInfoNotifier(Convert.ToString(new Shortcuts().ShortCuts(uiSwitch1.Active)));
            FPage1_Load(sender, e );
        }
    }
}
