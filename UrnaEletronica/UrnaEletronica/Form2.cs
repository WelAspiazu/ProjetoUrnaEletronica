using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form2 : Form
    {
        Thread formulario1;
        public Form2(int vtadilson, int vtalesandro, int vtfabio, int vtrodrigo, int vtalfredinho)
        {
            InitializeComponent();
            lb_vtAdilson.Text = vtadilson.ToString();
            lb_vtAlasandro.Text = vtalesandro.ToString();
            lb_vtFabio.Text = vtfabio.ToString();
            lb_vtRodrigo.Text = vtrodrigo.ToString();
            lb_vtAlfredinho.Text = vtalfredinho.ToString();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            
            this.Close(); // Fecha o formulário atual
            formulario1 = new Thread(newform1); // criar uma nova tread para o formulario2
            formulario1.SetApartmentState(ApartmentState.STA);  // indico que será uma Single thread
            formulario1.Start();  // Start
        }

        private void newform1(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
