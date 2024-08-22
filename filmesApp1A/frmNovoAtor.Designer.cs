namespace filmesApp1A
{
    partial class frmNovoAtor
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
            btCadastrar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbxNacionalidade = new ComboBox();
            SuspendLayout();
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(143, 218);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(132, 23);
            btCadastrar.TabIndex = 0;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(222, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 80);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 155);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Nacionalidade";
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(106, 147);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(222, 23);
            cbxNacionalidade.TabIndex = 5;
            // 
            // frmNovoAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 313);
            Controls.Add(cbxNacionalidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btCadastrar);
            Name = "frmNovoAtor";
            Text = "frmNovoAtor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCadastrar;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private ComboBox cbxNacionalidade;
    }
}