namespace First_Partial_GUI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bttnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgProblem = new System.Windows.Forms.PictureBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.lblChoose = new System.Windows.Forms.Label();
            this.bttnNextQ = new System.Windows.Forms.Button();
            this.bttnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgProblem)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(28, 20);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(96, 29);
            this.bttnBack.TabIndex = 8;
            this.bttnBack.TabStop = false;
            this.bttnBack.Text = "← Regresar";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 48);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "EJERCICIOS";
            // 
            // imgProblem
            // 
            this.imgProblem.Location = new System.Drawing.Point(113, 73);
            this.imgProblem.MaximumSize = new System.Drawing.Size(575, 500);
            this.imgProblem.MinimumSize = new System.Drawing.Size(575, 500);
            this.imgProblem.Name = "imgProblem";
            this.imgProblem.Size = new System.Drawing.Size(575, 500);
            this.imgProblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProblem.TabIndex = 10;
            this.imgProblem.TabStop = false;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(868, 240);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(87, 21);
            this.rbA.TabIndex = 11;
            this.rbA.Text = "Opción A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(868, 288);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(87, 21);
            this.rbB.TabIndex = 12;
            this.rbB.Text = "Opción B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(868, 336);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(87, 21);
            this.rbC.TabIndex = 13;
            this.rbC.Text = "Opción C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(868, 385);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(88, 21);
            this.rbD.TabIndex = 14;
            this.rbD.Text = "Opción D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(775, 182);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(275, 24);
            this.lblChoose.TabIndex = 15;
            this.lblChoose.Text = "Escoja la respuesta correcta:";
            // 
            // bttnNextQ
            // 
            this.bttnNextQ.Location = new System.Drawing.Point(931, 495);
            this.bttnNextQ.Name = "bttnNextQ";
            this.bttnNextQ.Size = new System.Drawing.Size(149, 48);
            this.bttnNextQ.TabIndex = 16;
            this.bttnNextQ.Text = "Siguiente →";
            this.bttnNextQ.UseVisualStyleBackColor = true;
            this.bttnNextQ.Click += new System.EventHandler(this.bttnNextQ_Click);
            // 
            // bttnCheck
            // 
            this.bttnCheck.Location = new System.Drawing.Point(761, 495);
            this.bttnCheck.Name = "bttnCheck";
            this.bttnCheck.Size = new System.Drawing.Size(149, 48);
            this.bttnCheck.TabIndex = 17;
            this.bttnCheck.Text = "Checar ejercicios";
            this.bttnCheck.UseVisualStyleBackColor = true;
            this.bttnCheck.Visible = false;
            this.bttnCheck.Click += new System.EventHandler(this.bttnCheck_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 633);
            this.Controls.Add(this.bttnCheck);
            this.Controls.Add(this.bttnNextQ);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.imgProblem);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.bttnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 680);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECHNION - Discrete Mathematics GUI";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgProblem;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button bttnNextQ;
        private System.Windows.Forms.Button bttnCheck;
    }
}