
namespace oseroGame
{
    partial class chooseFirstOrSecondForm
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cmb_firstOrSecond = new System.Windows.Forms.ComboBox();
            this.chooseFirstOrSecond = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cmb_firstOrSecond
            // 
            this.cmb_firstOrSecond.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_firstOrSecond.FormattingEnabled = true;
            this.cmb_firstOrSecond.Items.AddRange(new object[] {
            "         ",
            "先攻",
            "後攻"});
            this.cmb_firstOrSecond.Location = new System.Drawing.Point(309, 142);
            this.cmb_firstOrSecond.Name = "cmb_firstOrSecond";
            this.cmb_firstOrSecond.Size = new System.Drawing.Size(121, 30);
            this.cmb_firstOrSecond.TabIndex = 0;
            this.cmb_firstOrSecond.SelectedIndexChanged += new System.EventHandler(this.cmb_firstOrSecond_SelectedIndexChanged);
            // 
            // chooseFirstOrSecond
            // 
            this.chooseFirstOrSecond.AutoSize = true;
            this.chooseFirstOrSecond.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chooseFirstOrSecond.Location = new System.Drawing.Point(258, 75);
            this.chooseFirstOrSecond.Name = "chooseFirstOrSecond";
            this.chooseFirstOrSecond.Size = new System.Drawing.Size(234, 22);
            this.chooseFirstOrSecond.TabIndex = 1;
            this.chooseFirstOrSecond.Text = "先攻後攻を選んでください";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_save.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_save.Location = new System.Drawing.Point(330, 206);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 52);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "決定";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chooseFirstOrSecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.chooseFirstOrSecond);
            this.Controls.Add(this.cmb_firstOrSecond);
            this.Name = "chooseFirstOrSecondForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox cmb_firstOrSecond;
        private System.Windows.Forms.Label chooseFirstOrSecond;
        private System.Windows.Forms.Button btn_save;
    }
}