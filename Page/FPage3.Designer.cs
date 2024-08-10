namespace MiniTools.Page
{
    partial class FPage3
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
            this.uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            this.SuspendLayout();
            // 
            // uiComboTreeView1
            // 
            this.uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView1.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboTreeView1.Location = new System.Drawing.Point(335, 202);
            this.uiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView1.Name = "uiComboTreeView1";
            this.uiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView1.Size = new System.Drawing.Size(210, 98);
            this.uiComboTreeView1.SymbolSize = 24;
            this.uiComboTreeView1.TabIndex = 0;
            this.uiComboTreeView1.Text = "uiComboTreeView1";
            this.uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView1.Watermark = "";
            // 
            // FPage3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiComboTreeView1);
            this.Name = "FPage3";
            this.PageIndex = 1003;
            this.Symbol = 300051;
            this.Text = "窗口C";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboTreeView uiComboTreeView1;
    }
}