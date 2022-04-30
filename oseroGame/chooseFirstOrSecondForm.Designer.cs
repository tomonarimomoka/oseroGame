
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.cmb_firstOrSecond.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_firstOrSecond.FormattingEnabled = true;
            this.cmb_firstOrSecond.Items.AddRange(new object[] {
            "         ",
            "先攻",
            "後攻"});
            this.cmb_firstOrSecond.Location = new System.Drawing.Point(250, 94);
            this.cmb_firstOrSecond.Name = "cmb_firstOrSecond";
            this.cmb_firstOrSecond.Size = new System.Drawing.Size(135, 30);
            this.cmb_firstOrSecond.TabIndex = 0;
            this.cmb_firstOrSecond.SelectedIndexChanged += new System.EventHandler(this.cmb_firstOrSecond_SelectedIndexChanged);
            // 
            // chooseFirstOrSecond
            // 
            this.chooseFirstOrSecond.AutoSize = true;
            this.chooseFirstOrSecond.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chooseFirstOrSecond.Location = new System.Drawing.Point(105, 94);
            this.chooseFirstOrSecond.Name = "chooseFirstOrSecond";
            this.chooseFirstOrSecond.Size = new System.Drawing.Size(102, 22);
            this.chooseFirstOrSecond.TabIndex = 1;
            this.chooseFirstOrSecond.Text = "先攻後攻";
            this.chooseFirstOrSecond.Click += new System.EventHandler(this.chooseFirstOrSecond_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_save.Location = new System.Drawing.Point(170, 223);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 52);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "はじめる";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(105, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "モード";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSelectMode
            // 
            this.cmbSelectMode.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbSelectMode.FormattingEnabled = true;
            this.cmbSelectMode.Items.AddRange(new object[] {
            "",
            "接待モード",
            "初級モード",
            "中級モード"});
            this.cmbSelectMode.Location = new System.Drawing.Point(250, 152);
            this.cmbSelectMode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectMode.Name = "cmbSelectMode";
            this.cmbSelectMode.Size = new System.Drawing.Size(135, 30);
            this.cmbSelectMode.TabIndex = 4;
            this.cmbSelectMode.SelectedIndexChanged += new System.EventHandler(this.cmbSelectMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ようこそオセロゲームの世界へ！";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chooseFirstOrSecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSelectMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.chooseFirstOrSecond);
            this.Controls.Add(this.cmb_firstOrSecond);
            this.Name = "chooseFirstOrSecondForm";
            this.Text = "ようこそ！！";
            this.Load += new System.EventHandler(this.chooseFirstOrSecondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox cmb_firstOrSecond;
        private System.Windows.Forms.Label chooseFirstOrSecond;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectMode;
        private System.Windows.Forms.Label label2;
    }
}