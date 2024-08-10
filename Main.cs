using Sunny.UI;
using MiniTools.Page;
using System.Windows.Forms;

namespace MiniTools
{
    public partial class Main : UIHeaderAsideMainFrame
    {
        public Main()
        {
            int pageIndex = 1000;

            InitializeComponent();
            this.MainTabControl = MainTabControl;

            Header.TabControl = MainTabControl;
            Header.Nodes.Add("窗体");
            Header.Nodes.Add("主题");
            Header.SetNodePageIndex(Header.Nodes[0], 1003);
            TreeNode parent = Aside.CreateNode("窗体", 62160, 24, pageIndex);

            //parent = Aside.CreateNode("窗体", 61818, 24, pageIndex);
            Aside.CreateChildNode(parent, AddPage(new FPage1()));
            Aside.CreateChildNode(parent, AddPage(new FPage2()));
            Aside.CreateChildNode(parent, AddPage(new FPage3()));
            pageIndex = 2000;
            parent = Aside.CreateNode("测试", 62160, 24, pageIndex);

            //parent = Aside.CreateNode("窗体", 61818, 24, pageIndex);
            Aside.CreateChildNode(parent, AddPage(new FPage1()));
            Aside.CreateChildNode(parent, AddPage(new FPage2()));
            Aside.CreateChildNode(parent, AddPage(new FPage3()));

            Header.SetNodeSymbol(Header.Nodes[1], 61502);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[1], style.DisplayText(), style.Value());
            }
            //显示默认界面
            Aside.SelectFirst();
        }
        //主题颜色
        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 1:
                    UIStyle style = (UIStyle)pageIndex;
                    if (pageIndex < UIStyle.Colorful.Value())
                        StyleManager.Style = style;
                    break;
                default:
                    break;
            }
        }
    }
}
