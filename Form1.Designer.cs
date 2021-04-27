
namespace DateOfDeath
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTittleLeftToLive = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNeon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTittleLeftToLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DateOfDeath.Properties.Resources.DeathButton;
            this.pictureBox1.Location = new System.Drawing.Point(46, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBoxTittleLeftToLive
            // 
            this.pictureBoxTittleLeftToLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxTittleLeftToLive.Image = global::DateOfDeath.Properties.Resources.tittleLeftToLive2;
            this.pictureBoxTittleLeftToLive.Location = new System.Drawing.Point(80, 132);
            this.pictureBoxTittleLeftToLive.Name = "pictureBoxTittleLeftToLive";
            this.pictureBoxTittleLeftToLive.Size = new System.Drawing.Size(288, 91);
            this.pictureBoxTittleLeftToLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTittleLeftToLive.TabIndex = 1;
            this.pictureBoxTittleLeftToLive.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(5, 261);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(422, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "17 Лет, 138 Дней, 23 Часов, 13 Минут, 40 Секунд.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNeon
            // 
            this.pictureBoxNeon.Image = global::DateOfDeath.Properties.Resources.neonFrame;
            this.pictureBoxNeon.Location = new System.Drawing.Point(-29, 351);
            this.pictureBoxNeon.Name = "pictureBoxNeon";
            this.pictureBoxNeon.Size = new System.Drawing.Size(490, 223);
            this.pictureBoxNeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNeon.TabIndex = 3;
            this.pictureBoxNeon.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(36, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 152);
            this.label3.TabIndex = 4;
            this.label3.Text = "Я умру во время секс-вечеринки. Подруга позовёт меня на элитную оргию. Мы с ней б" +
    "ужем там единственными девушками. Нас свяжут и будут издеваться, пока мы не умрё" +
    "м от увечий";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DateOfDeath.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxNeon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTittleLeftToLive);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTittleLeftToLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxTittleLeftToLive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNeon;
        private System.Windows.Forms.Label label3;
    }
}

