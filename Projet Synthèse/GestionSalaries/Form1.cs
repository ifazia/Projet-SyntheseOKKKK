using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Commentaires pour essai
namespace GestionSalaraies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DialConnexion dialForm = new DialConnexion();
            dialForm.MdiParent = this;
            //dialForm.Show();
        }

        private void gestionUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUtilisateurs formUtil = new FrmUtilisateurs();
            formUtil.MdiParent = this;
            formUtil.WindowState = FormWindowState.Maximized ;

            formUtil.Show();
        }

        private void gestionSalariéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalaries formSalarie = new FrmSalaries();
            formSalarie.MdiParent = this;
            formSalarie.WindowState = FormWindowState.Maximized;

            formSalarie.Show();
        }

        
    }
}
