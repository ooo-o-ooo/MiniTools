namespace MiniTools
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiLogo1 = new Sunny.UI.UILogo();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.ItemHeight = 30;
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Size = new System.Drawing.Size(224, 488);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiLogo1);
            this.Header.Size = new System.Drawing.Size(1079, 110);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // uiLogo1
            // 
            this.uiLogo1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLogo1.Location = new System.Drawing.Point(0, 20);
            this.uiLogo1.MaximumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.MinimumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.Name = "uiLogo1";
            this.uiLogo1.Size = new System.Drawing.Size(300, 80);
            this.uiLogo1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLogo1.TabIndex = 2;
            this.uiLogo1.Text = "uiLogo1";
            // 
            // StyleManager
            // 
            this.StyleManager.DPIScale = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1079, 633);
            this.Name = "Main";
            this.Text = "小工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILogo uiLogo1;
        private Sunny.UI.UIStyleManager StyleManager;
    }
}

