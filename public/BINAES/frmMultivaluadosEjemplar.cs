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
        public int id_ISBN = 0;
        public int id_ISSN = 0;
        public int id_DOI = 0;
        public int id_ejemplar = 0;
        public int id_palabra_clave = 0;
        public string ISBN = "";
        public string ISSN = "";
        public string DOI = "";
        public String PalabrasClave = "";
        public frmMultivaluadosEjemplar()
        {
            InitializeComponent();
        }
        public frmMultivaluadosEjemplar(int id)
        {
            InitializeComponent();
            id_ejemplar = id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ISBN = txtISBN.Text;
            ISSN = txtISSN.Text;
            DOI = txtDOI.Text;
            PalabrasClave = txtPalabrasClave.Text;
            this.Close();
        }

        private void frmMultivaluadosEjemplar_Load(object sender, EventArgs e)
        {
            if (id_ejemplar > 0)
            {
                List<Etiqueta> listaEtiquetas = EtiquetaDAO.Leer(id_ejemplar);
                foreach (Etiqueta etiqueta in listaEtiquetas)
                {
                    if (etiqueta.nombre_etiqueta == "ISBN")
                    {
                        txtISBN.Text = etiqueta.etiqueta;
                        id_ISBN = etiqueta.id;
                    }
                    else if (etiqueta.nombre_etiqueta == "ISSN")
                    {
                        txtISSN.Text = etiqueta.etiqueta;
                        id_ISSN = etiqueta.id;
                    }
                    else
                    {
                        txtDOI.Text = etiqueta.etiqueta;
                        id_DOI = etiqueta.id;
                    }
                }
                List<PalabraClave> listaPalabras = PalabraClaveDAO.Leer(id_ejemplar);
                foreach(PalabraClave palabra in listaPalabras)
                {
                    txtPalabrasClave.AppendText(palabra.palabra + ',');
                }
                txtPalabrasClave.Text = txtPalabrasClave.Text.Remove(txtPalabrasClave.Text.Length - 1, 1);
            }
        }
    }
}
