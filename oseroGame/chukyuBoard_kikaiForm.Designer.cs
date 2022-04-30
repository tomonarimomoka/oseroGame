
namespace oseroGame
{
    partial class chukyuBoard_kikaiForm
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
            this.SuspendLayout();
            // 
            // btn_pass
            // 
            this.btn_pass.Visible = false;
            // 
            // chukyuBoard_kikaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(708, 737);
            this.Name = "chukyuBoard_kikaiForm";
            this.Text = "中級モード_kikai";
            this.Load += new System.EventHandler(this.chukyuBoard_kikaiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}