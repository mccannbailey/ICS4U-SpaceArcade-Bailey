namespace SpaceArcade2._0
{
    partial class TitleScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SingleButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SingleButton
            // 
            this.SingleButton.BackColor = System.Drawing.Color.Transparent;
            this.SingleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SingleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingleButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleButton.ForeColor = System.Drawing.Color.White;
            this.SingleButton.Location = new System.Drawing.Point(308, 444);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(180, 36);
            this.SingleButton.TabIndex = 0;
            this.SingleButton.Text = "Play Game";
            this.SingleButton.UseVisualStyleBackColor = false;
            this.SingleButton.Click += new System.EventHandler(this.SingleButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Red;
            this.QuitButton.Location = new System.Drawing.Point(308, 509);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(180, 36);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SpaceArcade2._0.Properties.Resources.TitleImage;
            this.pictureBox1.Location = new System.Drawing.Point(150, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 260);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceArcade2._0.Properties.Resources.background;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SingleButton);
            this.Name = "TitleScreen";
            this.Size = new System.Drawing.Size(800, 800);
            this.Load += new System.EventHandler(this.TitleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SingleButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
