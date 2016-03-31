namespace ROCVa_app_memory_game2
{
    partial class Start_Menu
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Spel_Titel = new System.Windows.Forms.Label();
            this.Start_Knop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ROCVa_app_memory_game2.Properties.Resources.Spongebob_Squarepants_Cartoons_Download;
            this.pictureBox2.Location = new System.Drawing.Point(-435, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1624, 687);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Spel_Titel
            // 
            this.Spel_Titel.AutoSize = true;
            this.Spel_Titel.BackColor = System.Drawing.Color.Yellow;
            this.Spel_Titel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spel_Titel.Location = new System.Drawing.Point(158, 41);
            this.Spel_Titel.Name = "Spel_Titel";
            this.Spel_Titel.Size = new System.Drawing.Size(524, 27);
            this.Spel_Titel.TabIndex = 2;
            this.Spel_Titel.Text = "Spongebob Squarepants Memory Game";
            // 
            // Start_Knop
            // 
            this.Start_Knop.BackColor = System.Drawing.Color.LightCoral;
            this.Start_Knop.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Knop.Location = new System.Drawing.Point(675, 392);
            this.Start_Knop.Name = "Start_Knop";
            this.Start_Knop.Size = new System.Drawing.Size(149, 51);
            this.Start_Knop.TabIndex = 3;
            this.Start_Knop.Text = "Speel Spel";
            this.Start_Knop.UseVisualStyleBackColor = false;
            this.Start_Knop.Click += new System.EventHandler(this.Start_Knop_Click);
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 604);
            this.Controls.Add(this.Start_Knop);
            this.Controls.Add(this.Spel_Titel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Start_Menu";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Spel_Titel;
        private System.Windows.Forms.Button Start_Knop;
    }
}