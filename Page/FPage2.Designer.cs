namespace MiniTools.Page
{
    partial class FPage2
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
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox1.Location = new System.Drawing.Point(262, 181);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox1.TabIndex = 0;
            this.uiCheckBox1.Text = "uiCheckBox1";
            // 
            // FPage2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiCheckBox1);
            this.Name = "FPage2";
            this.PageIndex = 1002;
            this.Symbol = 300050;
            this.Text = "窗口B";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UICheckBox uiCheckBox1;
    }
}