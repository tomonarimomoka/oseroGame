
namespace oseroGame
{
    partial class board_kikaiForm
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
            this.labelKikai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKikai
            // 
            this.labelKikai.AutoSize = true;
            this.labelKikai.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKikai.Location = new System.Drawing.Point(541, 61);
            this.labelKikai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKikai.Name = "labelKikai";
            this.labelKikai.Size = new System.Drawing.Size(142, 24);
            this.labelKikai.TabIndex = 28;
            this.labelKikai.Text = "機械の番です";
            // 
            // board_kikaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 1083);
            this.Controls.Add(this.labelKikai);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "board_kikaiForm";
            this.Text = "機械";
            this.Load += new System.EventHandler(this.board_kikaiForm_Load);
            this.Controls.SetChildIndex(this.labelKikai, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKikai;
    }
}