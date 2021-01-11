namespace Cadastro
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnCad = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.TxtExibir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(297, 393);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(173, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(297, 419);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(173, 20);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // BtnCad
            // 
            this.BtnCad.Location = new System.Drawing.Point(251, 458);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(149, 77);
            this.BtnCad.TabIndex = 2;
            this.BtnCad.Text = "CADASTRAR";
            this.BtnCad.UseVisualStyleBackColor = true;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(452, 198);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "button1";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(261, 201);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(173, 20);
            this.TxtBusca.TabIndex = 4;
            // 
            // TxtExibir
            // 
            this.TxtExibir.Location = new System.Drawing.Point(533, 198);
            this.TxtExibir.Name = "TxtExibir";
            this.TxtExibir.Size = new System.Drawing.Size(173, 20);
            this.TxtExibir.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 599);
            this.Controls.Add(this.TxtExibir);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnCad);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.TextBox TxtExibir;
    }
}

