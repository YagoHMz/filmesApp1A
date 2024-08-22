namespace filmesApp1A
{
    partial class frmAtores
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
            components = new System.ComponentModel.Container();
            dgvAtores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            button1 = new Button();
            txtBuscar = new TextBox();
            btBuscar = new Button();
            btCadastrar = new Button();
            button3 = new Button();
            atorBindingSource1 = new BindingSource(components);
            atorBindingSource2 = new BindingSource(components);
            filmeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(12, 65);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(776, 343);
            dgvAtores.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 26);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(659, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(677, 26);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(113, 23);
            btBuscar.TabIndex = 3;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 415);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(113, 23);
            btCadastrar.TabIndex = 4;
            btCadastrar.Text = "Cadastrar Ator";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(594, 415);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 5;
            button3.Text = "button2";
            button3.UseVisualStyleBackColor = true;
            // 
            // atorBindingSource1
            // 
            atorBindingSource1.DataSource = typeof(Models.Ator);
            // 
            // atorBindingSource2
            // 
            atorBindingSource2.DataSource = typeof(Models.Ator);
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // frmAtores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btCadastrar);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(button1);
            Controls.Add(dgvAtores);
            MaximizeBox = false;
            Name = "frmAtores";
            Text = "frmAtores";
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAtores;
        private Button button1;
        private TextBox txtBuscar;
        private Button btBuscar;
        private Button btCadastrar;
        private Button button3;
        private BindingSource atorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource1;
        private BindingSource atorBindingSource2;
        private BindingSource filmeBindingSource;
    }
}