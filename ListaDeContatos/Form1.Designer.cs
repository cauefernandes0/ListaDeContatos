namespace ListaDeContatos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelnome = new System.Windows.Forms.Label();
            this.labelsobrenome = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.ListBoxContatos = new System.Windows.Forms.ListBox();
            this.buttonIncluirContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(38, 74);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(70, 25);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome:";
            // 
            // labelsobrenome
            // 
            this.labelsobrenome.AutoSize = true;
            this.labelsobrenome.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsobrenome.Location = new System.Drawing.Point(38, 131);
            this.labelsobrenome.Name = "labelsobrenome";
            this.labelsobrenome.Size = new System.Drawing.Size(118, 25);
            this.labelsobrenome.TabIndex = 1;
            this.labelsobrenome.Text = "Sobrenome:";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(186, 131);
            this.textBoxSobrenome.Multiline = true;
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(189, 24);
            this.textBoxSobrenome.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(186, 80);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(189, 24);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(186, 177);
            this.textBoxTelefone.Multiline = true;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(189, 24);
            this.textBoxTelefone.TabIndex = 7;
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefone.Location = new System.Drawing.Point(38, 177);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(90, 25);
            this.labeltelefone.TabIndex = 8;
            this.labeltelefone.Text = "Telefone:";
            // 
            // ListBoxContatos
            // 
            this.ListBoxContatos.FormattingEnabled = true;
            this.ListBoxContatos.Location = new System.Drawing.Point(537, 18);
            this.ListBoxContatos.Name = "ListBoxContatos";
            this.ListBoxContatos.Size = new System.Drawing.Size(251, 420);
            this.ListBoxContatos.TabIndex = 9;
            // 
            // buttonIncluirContato
            // 
            this.buttonIncluirContato.Location = new System.Drawing.Point(43, 298);
            this.buttonIncluirContato.Name = "buttonIncluirContato";
            this.buttonIncluirContato.Size = new System.Drawing.Size(345, 140);
            this.buttonIncluirContato.TabIndex = 10;
            this.buttonIncluirContato.Text = "Incluir Contato";
            this.buttonIncluirContato.UseVisualStyleBackColor = true;
            this.buttonIncluirContato.Click += new System.EventHandler(this.buttonIncluirContato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIncluirContato);
            this.Controls.Add(this.ListBoxContatos);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelsobrenome);
            this.Controls.Add(this.labelnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelsobrenome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.ListBox ListBoxContatos;
        private System.Windows.Forms.Button buttonIncluirContato;
    }
}

