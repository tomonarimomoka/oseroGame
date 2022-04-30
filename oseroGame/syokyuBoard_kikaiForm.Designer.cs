
namespace oseroGame
{
    partial class syokyuBoard_kikaiForm
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
            // syokyuBoard_kikaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(715, 730);
            this.Name = "syokyuBoard_kikaiForm";
            this.Text = "初級モード_kikai";
            this.Load += new System.EventHandler(this.syokyuBoard_kikaiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}