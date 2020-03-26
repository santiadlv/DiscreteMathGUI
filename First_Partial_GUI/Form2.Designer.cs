namespace First_Partial_GUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgSlides = new System.Windows.Forms.PictureBox();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlides)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 48);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "TEORÍA";
            // 
            // imgSlides
            // 
            this.imgSlides.Location = new System.Drawing.Point(28, 62);
            this.imgSlides.MaximumSize = new System.Drawing.Size(1075, 520);
            this.imgSlides.Name = "imgSlides";
            this.imgSlides.Size = new System.Drawing.Size(1075, 520);
            this.imgSlides.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlides.TabIndex = 6;
            this.imgSlides.TabStop = false;
            this.imgSlides.Click += new System.EventHandler(this.imgSlides_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(28, 20);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(96, 29);
            this.bttnBack.TabIndex = 7;
            this.bttnBack.TabStop = false;
            this.bttnBack.Text = "← Regresar";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.Location = new System.Drawing.Point(577, 588);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(198, 36);
            this.bttnNext.TabIndex = 8;
            this.bttnNext.Text = "Siguiente → ";
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // bttnPrevious
            // 
            this.bttnPrevious.Enabled = false;
            this.bttnPrevious.Location = new System.Drawing.Point(373, 588);
            this.bttnPrevious.Name = "bttnPrevious";
            this.bttnPrevious.Size = new System.Drawing.Size(198, 36);
            this.bttnPrevious.TabIndex = 9;
            this.bttnPrevious.Text = "← Anterior";
            this.bttnPrevious.UseVisualStyleBackColor = true;
            this.bttnPrevious.Click += new System.EventHandler(this.bttnPrevious_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1132, 633);
            this.Controls.Add(this.bttnPrevious);
            this.Controls.Add(this.bttnNext);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.imgSlides);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 680);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECHNION - Discrete Mathematics GUI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgSlides;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Button bttnPrevious;
    }
}