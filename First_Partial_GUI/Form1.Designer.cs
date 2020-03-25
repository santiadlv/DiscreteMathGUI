namespace First_Partial_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.bttnTheory = new System.Windows.Forms.Button();
            this.bttnExercises = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(332, 279);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(477, 96);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "¡Bienvenido!";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(442, 43);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(257, 251);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // txtWelcome
            // 
            this.txtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcome.CausesValidation = false;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtWelcome.Location = new System.Drawing.Point(136, 416);
            this.txtWelcome.Multiline = true;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.ReadOnly = true;
            this.txtWelcome.Size = new System.Drawing.Size(534, 153);
            this.txtWelcome.TabIndex = 3;
            this.txtWelcome.TabStop = false;
            this.txtWelcome.Text = "Este pequeño programa te ayudará a recordar\r\ntodos los conceptos básicos de matem" +
    "áticas\r\ndiscretas, albmismo tiempo que te dejará poner\r\na prueba tus conocimient" +
    "os con un pequeño examen.";
            // 
            // bttnTheory
            // 
            this.bttnTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTheory.Location = new System.Drawing.Point(717, 426);
            this.bttnTheory.Name = "bttnTheory";
            this.bttnTheory.Size = new System.Drawing.Size(241, 50);
            this.bttnTheory.TabIndex = 4;
            this.bttnTheory.TabStop = false;
            this.bttnTheory.Text = "Revisar la teoría";
            this.bttnTheory.UseVisualStyleBackColor = true;
            this.bttnTheory.Click += new System.EventHandler(this.bttnTheory_Click);
            // 
            // bttnExercises
            // 
            this.bttnExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExercises.Location = new System.Drawing.Point(717, 494);
            this.bttnExercises.Name = "bttnExercises";
            this.bttnExercises.Size = new System.Drawing.Size(241, 50);
            this.bttnExercises.TabIndex = 5;
            this.bttnExercises.TabStop = false;
            this.bttnExercises.Text = "Contestar ejercicios";
            this.bttnExercises.UseVisualStyleBackColor = true;
            this.bttnExercises.Click += new System.EventHandler(this.bttnExercises_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 630);
            this.Controls.Add(this.bttnExercises);
            this.Controls.Add(this.bttnTheory);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECHNION - Discrete Math GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Button bttnTheory;
        private System.Windows.Forms.Button bttnExercises;
    }
}

