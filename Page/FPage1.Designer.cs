using MiniTools.Tools;

namespace MiniTools.Page
{
    partial class FPage1
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
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            this.uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiLabel1);
            this.uiTitlePanel1.Controls.Add(this.uiSwitch1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(4, 40);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(255, 180);
            this.uiTitlePanel1.TabIndex = 2;
            this.uiTitlePanel1.Text = "隐藏快捷图标小箭头";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSwitch1.Location = new System.Drawing.Point(91, 82);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(75, 29);
            this.uiSwitch1.TabIndex = 0;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.Location = new System.Drawing.Point(267, 40);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.ShowText = false;
            this.uiTitlePanel2.Size = new System.Drawing.Size(254, 180);
            this.uiTitlePanel2.TabIndex = 3;
            this.uiTitlePanel2.Text = "uiTitlePanel2";
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.Location = new System.Drawing.Point(529, 40);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.ShowText = false;
            this.uiTitlePanel3.Size = new System.Drawing.Size(267, 180);
            this.uiTitlePanel3.TabIndex = 4;
            this.uiTitlePanel3.Text = "uiTitlePanel3";
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiLabel1.Location = new System.Drawing.Point(3, 139);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(249, 23);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "uiLabel1";
            // 
            // FPage1
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTitlePanel3);
            this.Controls.Add(this.uiTitlePanel2);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "FPage1";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.PageIndex = 1001;
            this.ShowTitle = true;
            this.Symbol = 300049;
            this.Text = "窗口A";
            this.TitleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TitleForeColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FPage1_Load);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UISwitch uiSwitch1;
        private Sunny.UI.UILabel uiLabel1;
    }
}