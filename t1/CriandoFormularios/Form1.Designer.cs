namespace WindowsFormsApp1
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
            this.btnComoVcTa = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComoVcTa
            // 
            this.btnComoVcTa.Location = new System.Drawing.Point(45, 91);
            this.btnComoVcTa.Name = "btnComoVcTa";
            this.btnComoVcTa.Size = new System.Drawing.Size(176, 23);
            this.btnComoVcTa.TabIndex = 3;
            this.btnComoVcTa.Text = "Como você está?";
            this.btnComoVcTa.UseVisualStyleBackColor = true;
            this.btnComoVcTa.Click += new System.EventHandler(this.btnComoVcTa_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(45, 46);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(176, 23);
            this.btnPrimeiro.TabIndex = 2;
            this.btnPrimeiro.Text = "Primeiro programa C#";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 150);
            this.Controls.Add(this.btnComoVcTa);
            this.Controls.Add(this.btnPrimeiro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComoVcTa;
        private System.Windows.Forms.Button btnPrimeiro;
    }
}

