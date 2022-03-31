
namespace oseroGame
{
    partial class chooseFirstform
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmb_firstOrSecond = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "先攻後攻を選んでください。";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(277, 271);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "決定";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // cmb_firstOrSecond
            // 
            this.cmb_firstOrSecond.FormattingEnabled = true;
            this.cmb_firstOrSecond.Items.AddRange(new object[] {
            "選択してください。",
            "先攻",
            "後攻"});
            this.cmb_firstOrSecond.Location = new System.Drawing.Point(251, 127);
            this.cmb_firstOrSecond.Name = "cmb_firstOrSecond";
            this.cmb_firstOrSecond.Size = new System.Drawing.Size(121, 26);
            this.cmb_firstOrSecond.TabIndex = 3;
            this.cmb_firstOrSecond.SelectedIndexChanged += new System.EventHandler(this.cmb_firstOrSecond_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_firstOrSecond);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_firstOrSecond;
    }
}