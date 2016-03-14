namespace ROCVa_App_memory_game
{
    partial class memorygameStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memorygameStart));
            this.Startknop = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Startknop
            // 
            this.Startknop.BackColor = System.Drawing.SystemColors.Highlight;
            this.Startknop.ForeColor = System.Drawing.Color.Lime;
            this.Startknop.Location = new System.Drawing.Point(81, 212);
            this.Startknop.Name = "Startknop";
            this.Startknop.Size = new System.Drawing.Size(129, 39);
            this.Startknop.TabIndex = 0;
            this.Startknop.Text = "Begin";
            this.Startknop.UseVisualStyleBackColor = false;
            this.Startknop.Click += new System.EventHandler(this.Startknop_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.Yellow;
            this.welcomeText.Location = new System.Drawing.Point(-5, 36);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(296, 48);
            this.welcomeText.TabIndex = 1;
            this.welcomeText.Text = "Welkom bij de memory game.\r\nDruk op Begin om te beginnen";
            // 
            // memorygameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.Startknop);
            this.Name = "memorygameStart";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startknop;
        private System.Windows.Forms.Label welcomeText;
    }
}

