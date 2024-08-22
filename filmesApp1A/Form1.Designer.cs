namespace filmesApp1A
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
            components = new System.ComponentModel.Container();
            atorBindingSource = new BindingSource(components);
            bt_atores = new Button();
            br_Filme = new Button();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // bt_atores
            // 
            bt_atores.Location = new Point(81, 56);
            bt_atores.Name = "bt_atores";
            bt_atores.Size = new Size(139, 37);
            bt_atores.TabIndex = 0;
            bt_atores.Text = "Gerenciar Atores";
            bt_atores.UseVisualStyleBackColor = true;
            bt_atores.Click += bt_atores_Click;
            // 
            // br_Filme
            // 
            br_Filme.Location = new Point(81, 163);
            br_Filme.Name = "br_Filme";
            br_Filme.Size = new Size(139, 37);
            br_Filme.TabIndex = 1;
            br_Filme.Text = "Gerenciar Filmes";
            br_Filme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 353);
            Controls.Add(br_Filme);
            Controls.Add(bt_atores);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource atorBindingSource;
        private Button bt_atores;
        private Button br_Filme;
    }
}
