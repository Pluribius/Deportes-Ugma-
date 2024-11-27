using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ugma1
{
    public partial class portada : Form
    {
        public portada()
        {
            InitializeComponent();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();
            registroForm.Show();
            this.Hide();
        }
    }
}
