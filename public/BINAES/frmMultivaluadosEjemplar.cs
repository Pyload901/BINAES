using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public partial class frmMultivaluadosEjemplar : Form
    {
        public string ISBN = "";
        public string ISSN = "";
        public string DOI = "";
        public String PalabrasClave = "";
        public frmMultivaluadosEjemplar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ISBN = txtISBN.Text;
            ISSN = txtISSN.Text;
            DOI = txtDOI.Text;
            PalabrasClave = txtPalabrasClave.Text;
            this.Close();
        }
    }
}
