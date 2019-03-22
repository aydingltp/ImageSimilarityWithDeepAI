namespace ImageSimilarity
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnResim1 = new System.Windows.Forms.Button();
            this.btnResim2 = new System.Windows.Forms.Button();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(29, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(462, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnResim1
            // 
            this.btnResim1.Location = new System.Drawing.Point(171, 327);
            this.btnResim1.Name = "btnResim1";
            this.btnResim1.Size = new System.Drawing.Size(113, 27);
            this.btnResim1.TabIndex = 2;
            this.btnResim1.Text = "1. Resim";
            this.btnResim1.UseVisualStyleBackColor = true;
            // 
            // btnResim2
            // 
            this.btnResim2.Location = new System.Drawing.Point(603, 327);
            this.btnResim2.Name = "btnResim2";
            this.btnResim2.Size = new System.Drawing.Size(113, 27);
            this.btnResim2.TabIndex = 3;
            this.btnResim2.Text = "2. Resim";
            this.btnResim2.UseVisualStyleBackColor = true;
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(390, 327);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(100, 27);
            this.btnKarsilastir.TabIndex = 4;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(406, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.btnResim2);
            this.Controls.Add(this.btnResim1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnResim1;
        private System.Windows.Forms.Button btnResim2;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Label label1;
    }
}

