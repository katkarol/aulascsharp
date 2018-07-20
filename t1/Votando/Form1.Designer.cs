namespace Votando
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
            this.ckBrasileiro = new System.Windows.Forms.CheckBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ckBrasileiro
            // 
            this.ckBrasileiro.AutoSize = true;
            this.ckBrasileiro.Location = new System.Drawing.Point(77, 131);
            this.ckBrasileiro.Name = "ckBrasileiro";
            this.ckBrasileiro.Size = new System.Drawing.Size(68, 17);
            this.ckBrasileiro.TabIndex = 7;
            this.ckBrasileiro.Text = "Brasileiro";
            this.ckBrasileiro.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(77, 177);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 6;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(77, 80);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 261);
            this.Controls.Add(this.ckBrasileiro);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBrasileiro;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
    }
}

