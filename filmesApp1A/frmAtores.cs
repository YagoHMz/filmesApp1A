using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmAtores : Form
    {
        Form anterior;
        Contexto db;
        public frmAtores(Form anterior)
        {
            InitializeComponent();
            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();

            Recarregar("");
        }

        public void Recarregar(string buscar)
        {
            List<Ator> atores = this.db.Ator
                .Where(a => a.Nome.ToUpper().Contains(buscar.ToUpper()))
                .ToList();

            dgvAtores.DataSource = atores;

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoAtor f = new frmNovoAtor();
            f.ShowDialog();
            Recarregar(txtBuscar.Text);
        }
    }
}
