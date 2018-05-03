namespace SpaceArcade2._0
{
    partial class WindowScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.resumeLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthourLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.controlBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.controlBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(156, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(97, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Paused";
            // 
            // resumeLabel
            // 
            this.resumeLabel.AutoSize = true;
            this.resumeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeLabel.ForeColor = System.Drawing.Color.White;
            this.resumeLabel.Location = new System.Drawing.Point(120, 62);
            this.resumeLabel.Name = "resumeLabel";
            this.resumeLabel.Size = new System.Drawing.Size(174, 18);
            this.resumeLabel.TabIndex = 1;
            this.resumeLabel.Text = "press esc to resume";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Red;
            this.QuitButton.Location = new System.Drawing.Point(114, 198);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(180, 36);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Cyan;
            this.MenuButton.Location = new System.Drawing.Point(114, 131);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(180, 36);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "Main Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(1, 483);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(112, 13);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Space Arcade 2.0 ";
            // 
            // AuthourLabel
            // 
            this.AuthourLabel.AutoSize = true;
            this.AuthourLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthourLabel.ForeColor = System.Drawing.Color.White;
            this.AuthourLabel.Location = new System.Drawing.Point(276, 483);
            this.AuthourLabel.Name = "AuthourLabel";
            this.AuthourLabel.Size = new System.Drawing.Size(123, 13);
            this.AuthourLabel.TabIndex = 5;
            this.AuthourLabel.Text = "Bailey McCann 2018";
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.ForeColor = System.Drawing.Color.White;
            this.controlsLabel.Location = new System.Drawing.Point(145, 316);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(100, 23);
            this.controlsLabel.TabIndex = 6;
            this.controlsLabel.Text = "Controls";
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.DarkGray;
            this.controlBox.BackgroundImage = global::SpaceArcade2._0.Properties.Resources.controls;
            this.controlBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.controlBox.Location = new System.Drawing.Point(28, 273);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(341, 172);
            this.controlBox.TabIndex = 7;
            this.controlBox.TabStop = false;
            // 
            // WindowScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.AuthourLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.resumeLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "WindowScreen";
            this.Size = new System.Drawing.Size(400, 500);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WindowScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.controlBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label resumeLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthourLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.PictureBox controlBox;
    }
}
