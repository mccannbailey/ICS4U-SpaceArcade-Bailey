namespace SpaceArcade2._0
{
    partial class SingleScreen
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.outputLabel = new System.Windows.Forms.Label();
            this.heartBox1 = new System.Windows.Forms.PictureBox();
            this.heartBox2 = new System.Windows.Forms.PictureBox();
            this.heartBox3 = new System.Windows.Forms.PictureBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.rockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heartBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 40;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(305, 285);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(204, 59);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "output";
            // 
            // heartBox1
            // 
            this.heartBox1.BackColor = System.Drawing.Color.Transparent;
            this.heartBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heartBox1.Location = new System.Drawing.Point(22, 712);
            this.heartBox1.Name = "heartBox1";
            this.heartBox1.Size = new System.Drawing.Size(50, 50);
            this.heartBox1.TabIndex = 2;
            this.heartBox1.TabStop = false;
            // 
            // heartBox2
            // 
            this.heartBox2.BackColor = System.Drawing.Color.Transparent;
            this.heartBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heartBox2.Location = new System.Drawing.Point(78, 712);
            this.heartBox2.Name = "heartBox2";
            this.heartBox2.Size = new System.Drawing.Size(50, 50);
            this.heartBox2.TabIndex = 3;
            this.heartBox2.TabStop = false;
            // 
            // heartBox3
            // 
            this.heartBox3.BackColor = System.Drawing.Color.Transparent;
            this.heartBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heartBox3.Location = new System.Drawing.Point(134, 712);
            this.heartBox3.Name = "heartBox3";
            this.heartBox3.Size = new System.Drawing.Size(50, 50);
            this.heartBox3.TabIndex = 4;
            this.heartBox3.TabStop = false;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.ForeColor = System.Drawing.Color.White;
            this.CountLabel.Location = new System.Drawing.Point(731, 708);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(37, 41);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "0";
            // 
            // rockLabel
            // 
            this.rockLabel.AutoSize = true;
            this.rockLabel.BackColor = System.Drawing.Color.Transparent;
            this.rockLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockLabel.ForeColor = System.Drawing.Color.White;
            this.rockLabel.Location = new System.Drawing.Point(698, 749);
            this.rockLabel.Name = "rockLabel";
            this.rockLabel.Size = new System.Drawing.Size(100, 22);
            this.rockLabel.TabIndex = 6;
            this.rockLabel.Text = "Moonrocks";
            // 
            // SingleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceArcade2._0.Properties.Resources.background;
            this.Controls.Add(this.rockLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.heartBox3);
            this.Controls.Add(this.heartBox2);
            this.Controls.Add(this.heartBox1);
            this.Controls.Add(this.outputLabel);
            this.DoubleBuffered = true;
            this.Name = "SingleScreen";
            this.Size = new System.Drawing.Size(800, 800);
            this.Load += new System.EventHandler(this.SingleScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SingleScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SingleScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SingleScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.heartBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox heartBox1;
        private System.Windows.Forms.PictureBox heartBox2;
        private System.Windows.Forms.PictureBox heartBox3;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label rockLabel;
    }
}
