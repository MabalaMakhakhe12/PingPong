namespace PingPong
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.LblTitle = new System.Windows.Forms.Label();
            this.characterOne = new System.Windows.Forms.PictureBox();
            this.characterTwo = new System.Windows.Forms.PictureBox();
            this.characterThree = new System.Windows.Forms.PictureBox();
            this.characterFour = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterFour)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(60, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(633, 99);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Click A Character";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterOne
            // 
            this.characterOne.Image = ((System.Drawing.Image)(resources.GetObject("characterOne.Image")));
            this.characterOne.Location = new System.Drawing.Point(49, 194);
            this.characterOne.Name = "characterOne";
            this.characterOne.Size = new System.Drawing.Size(160, 160);
            this.characterOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterOne.TabIndex = 1;
            this.characterOne.TabStop = false;
            this.characterOne.Click += new System.EventHandler(this.characterOne_Click);
            // 
            // characterTwo
            // 
            this.characterTwo.Image = ((System.Drawing.Image)(resources.GetObject("characterTwo.Image")));
            this.characterTwo.Location = new System.Drawing.Point(235, 194);
            this.characterTwo.Name = "characterTwo";
            this.characterTwo.Size = new System.Drawing.Size(160, 160);
            this.characterTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterTwo.TabIndex = 2;
            this.characterTwo.TabStop = false;
            this.characterTwo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // characterThree
            // 
            this.characterThree.Image = ((System.Drawing.Image)(resources.GetObject("characterThree.Image")));
            this.characterThree.Location = new System.Drawing.Point(410, 194);
            this.characterThree.Name = "characterThree";
            this.characterThree.Size = new System.Drawing.Size(160, 160);
            this.characterThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterThree.TabIndex = 3;
            this.characterThree.TabStop = false;
            this.characterThree.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // characterFour
            // 
            this.characterFour.Image = ((System.Drawing.Image)(resources.GetObject("characterFour.Image")));
            this.characterFour.Location = new System.Drawing.Point(599, 194);
            this.characterFour.Name = "characterFour";
            this.characterFour.Size = new System.Drawing.Size(160, 160);
            this.characterFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterFour.TabIndex = 4;
            this.characterFour.TabStop = false;
            this.characterFour.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 482);
            this.Controls.Add(this.characterFour);
            this.Controls.Add(this.characterThree);
            this.Controls.Add(this.characterTwo);
            this.Controls.Add(this.characterOne);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterForm";
            this.Text = "Choose a Character";
            ((System.ComponentModel.ISupportInitialize)(this.characterOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterFour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox characterOne;
        private System.Windows.Forms.PictureBox characterTwo;
        private System.Windows.Forms.PictureBox characterThree;
        private System.Windows.Forms.PictureBox characterFour;
    }
}