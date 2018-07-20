namespace Multiplos3
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
            this.btnMultiplos3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiplos3
            // 
            this.btnMultiplos3.Location = new System.Drawing.Point(81, 71);
            this.btnMultiplos3.Name = "btnMultiplos3";
            this.btnMultiplos3.Size = new System.Drawing.Size(110, 23);
            this.btnMultiplos3.TabIndex = 0;
            this.btnMultiplos3.Text = "Ver multiplos de 3";
            this.btnMultiplos3.UseVisualStyleBackColor = true;
            this.btnMultiplos3.Click += new System.EventHandler(this.btnMultiplos3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 144);
            this.Controls.Add(this.btnMultiplos3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMultiplos3;
    }
}

