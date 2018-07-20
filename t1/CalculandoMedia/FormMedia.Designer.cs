namespace CalculandoMedia
{
    partial class FormMedia
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade3 = new System.Windows.Forms.TextBox();
            this.txtIdade2 = new System.Windows.Forms.TextBox();
            this.txtIdade1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(95, 190);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(121, 23);
            this.btnMedia.TabIndex = 13;
            this.btnMedia.Text = "Ver média das idades";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Idade 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Idade2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Idade 1";
            // 
            // txtIdade3
            // 
            this.txtIdade3.Location = new System.Drawing.Point(95, 135);
            this.txtIdade3.Name = "txtIdade3";
            this.txtIdade3.Size = new System.Drawing.Size(121, 20);
            this.txtIdade3.TabIndex = 9;
            // 
            // txtIdade2
            // 
            this.txtIdade2.Location = new System.Drawing.Point(95, 78);
            this.txtIdade2.Name = "txtIdade2";
            this.txtIdade2.Size = new System.Drawing.Size(121, 20);
            this.txtIdade2.TabIndex = 8;
            // 
            // txtIdade1
            // 
            this.txtIdade1.Location = new System.Drawing.Point(95, 23);
            this.txtIdade1.Name = "txtIdade1";
            this.txtIdade1.Size = new System.Drawing.Size(121, 20);
            this.txtIdade1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 296);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdade3);
            this.Controls.Add(this.txtIdade2);
            this.Controls.Add(this.txtIdade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade3;
        private System.Windows.Forms.TextBox txtIdade2;
        private System.Windows.Forms.TextBox txtIdade1;
    }
}

