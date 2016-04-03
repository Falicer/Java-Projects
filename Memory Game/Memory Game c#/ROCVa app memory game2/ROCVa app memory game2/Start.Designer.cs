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
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ROCVa_app_memory_game2.Properties.Resources.Spongebob_Squarepants_Cartoons_Download;
            this.pictureBox2.Location = new System.Drawing.Point(-326, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1218, 558);
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
            this.Spel_Titel.Location = new System.Drawing.Point(118, 33);
            this.Spel_Titel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Spel_Titel.Name = "Spel_Titel";
            this.Spel_Titel.Size = new System.Drawing.Size(420, 22);
            this.Spel_Titel.TabIndex = 2;
            this.Spel_Titel.Text = "Spongebob Squarepants Memory Game";
            // 
            // Start_Knop
            // 
            this.Start_Knop.BackColor = System.Drawing.Color.LightCoral;
            this.Start_Knop.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Knop.Location = new System.Drawing.Point(506, 318);
            this.Start_Knop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_Knop.Name = "Start_Knop";
            this.Start_Knop.Size = new System.Drawing.Size(112, 41);
            this.Start_Knop.TabIndex = 3;
            this.Start_Knop.Text = "Speel Spel";
            this.Start_Knop.UseVisualStyleBackColor = false;
            this.Start_Knop.Click += new System.EventHandler(this.Start_Knop_Click);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.LightCoral;
            this.Close_button.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(506, 383);
            this.Close_button.Margin = new System.Windows.Forms.Padding(2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(112, 41);
            this.Close_button.TabIndex = 4;
            this.Close_button.Text = "Sluiten";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 491);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Start_Knop);
            this.Controls.Add(this.Spel_Titel);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button Close_button;
    }
}