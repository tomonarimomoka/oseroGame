
namespace oseroGame
{
    partial class board_humanForm
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
            this.labelHuman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHuman
            // 
            this.labelHuman.AutoSize = true;
            this.labelHuman.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHuman.Location = new System.Drawing.Point(412, 43);
            this.labelHuman.Name = "labelHuman";
            this.labelHuman.Size = new System.Drawing.Size(154, 24);
            this.labelHuman.TabIndex = 28;
            this.labelHuman.Text = "あなたの番です";
            this.labelHuman.Click += new System.EventHandler(this.labelHuman_Click);
            // 
            // board_humanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 858);
            this.Controls.Add(this.labelHuman);
            this.Name = "board_humanForm";
            this.Text = "あなた";
            this.Controls.SetChildIndex(this.labelHuman, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHuman;
    }
}