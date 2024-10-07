namespace BlocoDeNotasWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Abrir = new Button();
            Desencriptar = new Button();
            Encriptar = new Button();
            Salvar = new Button();
            labelNomeDoArquivo = new Label();
            textBoxConteudo = new TextBox();
            SuspendLayout();
            // 
            // Abrir
            // 
            Abrir.BackColor = SystemColors.MenuHighlight;
            Abrir.Location = new Point(22, 22);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(117, 23);
            Abrir.TabIndex = 0;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = false;
            Abrir.Click += Abrir_Click;
            // 
            // Desencriptar
            // 
            Desencriptar.BackColor = Color.FromArgb(128, 255, 128);
            Desencriptar.Location = new Point(380, 24);
            Desencriptar.Name = "Desencriptar";
            Desencriptar.Size = new Size(114, 23);
            Desencriptar.TabIndex = 1;
            Desencriptar.Text = "Desencriptar";
            Desencriptar.UseVisualStyleBackColor = false;
            Desencriptar.Click += Desencriptar_Click;
            // 
            // Encriptar
            // 
            Encriptar.BackColor = Color.IndianRed;
            Encriptar.Location = new Point(267, 24);
            Encriptar.Name = "Encriptar";
            Encriptar.Size = new Size(107, 23);
            Encriptar.TabIndex = 2;
            Encriptar.Text = "Encriptar";
            Encriptar.UseVisualStyleBackColor = false;
            Encriptar.Click += Encriptar_Click;
            // 
            // Salvar
            // 
            Salvar.BackColor = SystemColors.WindowFrame;
            Salvar.Location = new Point(145, 22);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(116, 23);
            Salvar.TabIndex = 3;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // labelNomeDoArquivo
            // 
            labelNomeDoArquivo.AutoSize = true;
            labelNomeDoArquivo.Location = new Point(500, 28);
            labelNomeDoArquivo.Name = "labelNomeDoArquivo";
            labelNomeDoArquivo.Size = new Size(110, 15);
            labelNomeDoArquivo.TabIndex = 4;
            labelNomeDoArquivo.Text = "\"Nome do arquivo\"";
            labelNomeDoArquivo.Click += labelNomeDoArquivo_Click;
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConteudo.Location = new Point(22, 61);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.Size = new Size(588, 377);
            textBoxConteudo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(textBoxConteudo);
            Controls.Add(labelNomeDoArquivo);
            Controls.Add(Salvar);
            Controls.Add(Encriptar);
            Controls.Add(Desencriptar);
            Controls.Add(Abrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Abrir;
        private Button Desencriptar;
        private Button Encriptar;
        private Button Salvar;
        private Label labelNomeDoArquivo;
        private TextBox textBoxConteudo;
    }
}
