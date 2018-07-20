namespace ContaBancaria
{
    partial class CadastroConta
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
            this.txtTitularConta = new System.Windows.Forms.TextBox();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTitularConta
            // 
            this.txtTitularConta.Location = new System.Drawing.Point(80, 60);
            this.txtTitularConta.Name = "txtTitularConta";
            this.txtTitularConta.Size = new System.Drawing.Size(100, 20);
            this.txtTitularConta.TabIndex = 0;
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(80, 97);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroConta.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(80, 164);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Items.AddRange(new object[] {
            "Poupança",
            "Investimento"});
            this.cmbTipoConta.Location = new System.Drawing.Point(80, 124);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoConta.TabIndex = 3;
            // 
            // CadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTipoConta);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.txtTitularConta);
            this.Name = "CadastroConta";
            this.Text = "CadastroConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitularConta;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbTipoConta;
    }
}